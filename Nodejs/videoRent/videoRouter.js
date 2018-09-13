var express = require('express');
var fs = require('fs');

var MongoClient = require('mongodb').MongoClient
var url = 'mongodb+srv://ses:1234@cluster0-bzfnf.mongodb.net/videoList';
//var url = 'mongodb://localhost:27017/videolist';
const videoModel = require('./videoModel');
var db;
var ObjectID = require('mongodb').ObjectID;
MongoClient.connect(url, function (err, client) {
   if (err) {
      console.error('MongoDB 연결 실패', err);
      return;
   }
   const collection = client.db("videoList");
   console.log(collection);
   db = collection;
});

// 라우터 얻기
var router=express.Router();
router.route('/insert')
	.get(insertData);

router.route('/videos')
	.get(showVideoList)
	.post(addVideo);

router.route('/videos/:id')
	.get(showVideoDetail)
	.delete(deleteVideo)
	.put(editVideo);	
	
router.route('/reviews/:title')
	.get(showReviews)
	.post(addReview);	

router.route('/rent/:id')
	.put(rentVideo);	

router.route('/rentList/:rent')
	.get(showRent)
router.route('/videos/cost/:cost')
	.get(sortVideoList)

router.route('/videos/year/:year')
	.get(sortByYear)

router.route('/return/:id')
	.put(returnVideo)
module.exports = router;

async function insertData(req, res, next) {
	try {
		let result = await videoModel.insertDt();
		res.send({msg:'완료되었습니다.'});
	}
	catch ( error ) {
		next(error);
	}	
}
async function showReviews(req, res, next) {
	let title =req.params.title;
	try {
		let result = await videoModel.getReviewList(title);
		res.send(result.리뷰);
	}
	catch ( error ) {
		next(error);
	}	
}

async function addReview(req, res) {
	const title = req.params.title;
	//const videoId = req.params.id;
    if (!title) {
        res.status(400).send({error:'title 누락'});
        return;
    }
    const review = req.body.review;
    try {
        const result = await videoModel.addReview(title, review);
        res.send({리뷰 : review, msg:'리뷰 추가가 완료되었습니다.'});
    }
    catch ( error ) {
		next(error);
    }
}


// 전체 도큐먼트 목록 얻기
function showVideoList(req, res, next) {
   // 직접 데이터베이스에 접근
	// db.collection('movies').find({}).toArray((err, docs) => {
	// 	if ( err ) {
	// 		return next(err);
	// 	}

	// 	let result = {
	// 		count: docs.length,
	// 		data: docs
	// 	}		
	// 	res.send(result);
	// });

	// 모델 사용 - 콜백 기반
	// movieModel.getMovieList( (err, results) => {
	// 	if ( err ) {
	// 		return next(err);
	// 	}

	// 	let resObj = {
	// 		count: results.length,
	// 		data: results
	// 	}		
	// 	res.send(resObj);
	// });

	videoModel.getVideoList().then( results => {
		let resObj = {
			count: results.length,
			data: results
		}		
		res.send(resObj);
	}).catch( error => {
		console.log('error : ', error);
		next(error);
	});
}

async function showVideoDetail(req, res, next) {
	let videoId = req.params.id;
	try {
		let result = await videoModel.getVideoDetail(videoId);
		res.send(result);
	}
	catch ( error ) {
		next(error);
	}	
}

function sortVideoList(req, res, next) {
	const cost = req.params.cost;
	videoModel.getSortList(cost).then( results => {
		let resObj = {
			count: results.length,
			data: results
		}		
		res.send(resObj);
	}).catch( error => {
		console.log('error : ', error);
		next(error);
	});
}

function sortByYear(req, res, next) {
	const year = parseInt(req.params.year);
	videoModel.getSortYear(year).then( results => {
		let resObj = {
			count: results.length,
			data: results
		}		
		res.send(resObj);
	}).catch( error => {
		console.log('error : ', error);
		next(error);
	});
}

async function addVideo(req, res) {
    const title = req.body.title;

    if (!title) {
        res.status(400).send({error:'title 누락'});
        return;
    }

    const director = req.body.director;
    const year = parseInt(req.body.year);
	const context = req.body.context;
	const genre = req.body.genre;
	const cost = req.body.cost;
	const rent = req.body.rent;
	const sort = req.body.sort;
	const actor = req.body.actor;

    try {
        const result = await videoModel.addVideo(title, director, year, context, genre, cost, rent, sort, actor);
        res.send({제목 : title, msg:'비디오 추가가 완료되었습니다.'});
    }
    catch ( error ) {
		next(error);
    }
}

async function deleteVideo(req, res) {
	let videoId = req.params.id;
	try {
		let result = await videoModel.deleteVideo(videoId);
		res.send({msg:'비디오 삭제 완료'});
	}
	catch ( error ) {
		next(error);
	}
}

// 영화 수정
async function editVideo(req, res) {
	const title = req.body.title;
	
	const videoId = req.params.id;
	const director = req.body.director;
    const year = parseInt(req.body.year);
	const context = req.body.context;
	const genre = req.body.genre;
	const cost = req.body.cost;
	const rent = req.body.rent;
	const sort = req.body.sort;
	const actor = req.body.actor;

	try {
        const result = await videoModel.editVideo(videoId, title, director, year, context, genre, cost, rent, sort, actor);
		res.send({제목:title, msg:'영화 수정 완료' });
		//res.send(result);
    }
    catch ( error ) {
        res.status(500).send(error.msg);
    }
}
function showRent(req, res, next) {
	let rent = req.params.rent;
	videoModel.getRentList(rent).then( results => {
		let resObj = {
			count: results.length,
			data: results
		}		
		res.send(resObj);
	}).catch( error => {
		console.log('error : ', error);
		next(error);
	});

}
function rentVideo(req, res) {
	const id = req.params.id;
	let text;
	//const videoId = req.params.id;
    try {
		db.collection('videos').find({_id:new ObjectID(id)}).toArray((err, docs) => {
			for(var j=0; j<docs.length; j++){
				var doc = docs[j];
				if(doc['대여여부'] != 'X'){
					text = '0';
				}
				else{
					 text='1';
				}
			}  
			let result =  videoModel.getRent(id);
			console.log(text);
			if(text == '0'){
			res.send({ msg:'비디오 대여 완료되었습니다.'});
			}
			else{
				res.send({ msg:'비디오가 이미 대여중입니다.'});
			}
		})
		
    }
    catch ( error ) {
		next(error);
    }
}

 function returnVideo(req, res) {
	const id = req.params.id;
	//const videoId = req.params.id;
	let text;
    try {
		db.collection('videos').find({_id:new ObjectID(id)}).toArray((err, docs) => {
			for(var j=0; j<docs.length; j++){
				var doc = docs[j];
				if(doc['대여여부'] != 'X'){
					text = '1';
				}
				else{
					 text='0';
				}
			}  
		const result =  videoModel.getReturnV(id);
			if(text == '0'){
				res.send({ msg:'비디오 반납 완료되었습니다.'});
			}
			else{
				res.send({lsg: '이미 반납됐거나 대여중이지 않은 비디오입니다.'});
			}
        
		})
		
    }
    catch ( error ) {
		next(error);
    }
}



