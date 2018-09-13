package com.test.wDAO;

public class Company {
	String name;
	String tel;
	String ftel;
	String address;
	
	public Company(){}
	public Company(String name, String tel, String ftel, String address){
		this.name = name;
		this.tel = tel;
		this.ftel = ftel;
		this.address = address;
		
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getTel() {
		return tel;
	}
	public void setTel(String tel) {
		this.tel = tel;
	}
	public String getFtel() {
		return ftel;
	}
	public void setFtel(String ftel) {
		this.ftel = ftel;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	
	
}
