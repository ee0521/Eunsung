var MongoClient = require('mongodb').MongoClient
var url = 'mongodb+srv://ses:1234@cluster0-bzfnf.mongodb.net/videosList';

//var url='mongodb://localhost:27017/videolist';
var ObjectID = require('mongodb').ObjectID;

var db;

MongoClient.connect(url, function (err, client) {
    if (err) {
       console.error('MongoDB 연결 실패', err);
       return;
    }
    const collection = client.db("videoList");
    console.log(collection);
    db = collection;
 });

class VideoModel {

    insertDt(){
        return db.collection('videos').insertMany([
            {
                제목:"Avatar",
                감독:"제임스 카메론",
                주연:"샘 워싱턴, 조 샐다나",
                개봉:2009,
                장르 : "SF, 모험",
                줄거리:"인류의 마지막 희망, 행성 판도라! 이 곳을 정복하기 위한 ‘아바타 프로젝트’가 시작된다! 가까운 미래, 지구는 에너지 고갈 문제를 해결하기 위해 머나먼 행성 판도라에서 대체 자원을 채굴하기 시작한다. 하지만 판도라의 독성을 지닌 대기로 인해 자원 획득에 어려움을 겪게 된 인류는 판도라의 토착민 ‘나비(Na’vi)’의 외형에 인간의 의식을 주입, 원격 조종이 가능한 새로운 생명체 ‘아바타’를 탄생시키는 프로그램을 개발한다.",
                분류 : "구",
                대여료 : "500",
                대여여부 : "O",
                reviews:[]		
            },
            {
                제목:"StarWars",
                감독:"조지 루카스",
                주연:"리암 니슨",
                개봉:1977,
                장르 : "액션",
                줄거리:"평화롭던 은하계에서 타킨총독(피터 커슁)이 왕정에 저항하여 제국을 일으킨다.",
                분류 : "구",
                대여료 : "500",
                대여여부 : "O",
                reviews:[]			
            },
            {
                제목:"Interstellar",
                감독:"크리스토퍼 놀란",
                주연:"앤 해서웨이",
                개봉:2014,
                장르 : "SF",
                줄거리:"세계 각국의 정부와 경제가 완전히 붕괴된 미래가 다가온다. 지난...",
                분류 : "신",
                대여료 : "1000",
                대여여부 : "O",
                reviews:[]		
            },
            {
                제목:"Avengers",
                감독:"안소니 루소",
                주연:"조슈 브롤린, 크리스 프랫",
                개봉:2014,
                장르 : "모험, 판타지",
                줄거리:"새로운 조합을 이룬 어벤져스, 역대 최강 빌런 타노스에 맞서 세계의 운명이 걸린 인피니티 스톤을 향한 무한 대결이 펼쳐진다! ",
                분류 : "최신",
                대여료 : "1500",
                대여여부 : "O",
                reviews:[]		
            }
        ])
    }
   // 전체 도큐먼트 목록 얻기
   getVideoList(callback) {
      // 콜백 기반
      // return db.collection('movies').find({}).toArray((err, docs) => {
      //    if ( err ) {
      //       return callback(err);
      //    }

      //    callback(null, docs);
      // });      

      // 프라미스 기반
      // return new Promise( (resolve, reject) => {
      //    db.collection('movies').find({}).toArray()
      //    .then( result => {
      //       resolve(result);
      //    })
      //    .catch( error => {
      //       reject(error);
      //    });
      // });       

      // 프라미스 기반2
      return db.collection('videos').find({}).toArray()
   }

   getVideoDetail(id) {
      return db.collection('videos').findOne({_id:new ObjectID(id)})
   }

   addVideo(title, director, year, context, genre, cost, rent, sort, actor) {
       // TODO
        if(rent==null){
            rent = "가능";
        }
       return db.collection('videos').insertOne({제목 : title, 감독 : director, 주연 : actor, 개봉 : year, 
        장르 : genre, 줄거리 : context, 대여료 : cost, 대여여부 : rent, 분류 : sort })
      
   }

   deleteVideo(videoId){
       return db.collection('videos').deleteOne({_id:new ObjectID(videoId)})
   }

   editVideo(videoId, title, director, year, context, genre, cost, rent, sort, actor){

        if(rent==null){
            rent = "가능";
        }
        let data = [title, director, actor, year, genre, context, cost, rent, sort];
        const data2 = ['제목', '감독', '주연', '개봉', '장르', '줄거리', '대여료', '대여여부', '분류'];
        //const rData = db.collection('videos').find({_id:new ObjectID(videoId)}).toArray();
        const length = data.length -1;
        
        db.collection('videos').find({_id:new ObjectID(videoId)}).toArray((err, docs) => {
            for(var j=0; j<docs.length; j++){
                var doc = docs[j];
               
                for(var i=0; i<=length; i++){
                    //console.log(isNaN(data[3]));
                    //boolean a = ture;
                    if(data[i] == null || isNaN(data[3])){
                        data[i] = doc[data2[i]];
                    }
                    //console.log(data[i]);
                }
                
            }
            return db.collection('videos').update({_id:new ObjectID(videoId)}, {$set:{제목 : data[0], 감독 : data[1], 주연 : data[2],
                개봉 : data[3], 장르 : data[4], 줄거리 : data[5],  대여료 : data[6], 대여여부 : data[7], 분류 : data[8] }})
        })
   
   }
        getReviewList(title) {
            return db.collection('videos').findOne({제목:title})
        }

        addReview(title, review){
            return db.collection('videos').update({제목:title}, {$push:{리뷰 : review}})
        }   

        getSortList(cost){
            return db.collection('videos').find({대여료:cost}).toArray()
        }

        getSortYear(year){
            return db.collection('videos').find({개봉:{$gte:year}}).toArray()

        }
        getRentList(rent){
            return db.collection('videos').find({대여여부:rent}).toArray()

        }

        getRent(id){
            //let data = db.collection('videos').find({제목:title}).toArray();
            let videoId = id;
            let rentV;
            let text;
            db.collection('videos').find({_id:new ObjectID(videoId)}).toArray((err, docs) => {
                for(var j=0; j<docs.length; j++){
                    var doc = docs[j];
                    if(doc['대여여부'] != 'X'){
                        rentV = 'X';
                        text = db.collection('videos').update({_id:new ObjectID(videoId)}, {$set:{대여여부 : rentV}});
                    }
                    else{
                         text='1';
                    }    
                } 
                return text;
                })
               
        }
        getReturnV(id){
            let videoId = id;
            let value = 'O';
            return db.collection('videos').update({_id:new ObjectID(videoId)}, {$set:{대여여부 : value}});
        }

}

module.exports = new VideoModel()