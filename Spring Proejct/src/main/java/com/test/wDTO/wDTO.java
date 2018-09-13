package com.test.wDTO;

public class wDTO {
	private int wid;
	private int wprice;
	private String wname;
	private String wfrom;
	private String wcontent;
	private String wgroup;
	
	public wDTO(){};
	
	public wDTO(int wid, int wprice, String wname, String wfrom, String wcontent,
			String wgroup){
		this.wid = wid;
		this.wprice = wprice;
		this.wname = wname;
		this.wfrom = wfrom;
		this.wcontent = wcontent;
		this.wgroup = wgroup;
		
	}

	public int getWid() {
		return wid;
	}

	public void setWid(int wid) {
		this.wid = wid;
	}

	public int getWprice() {
		return wprice;
	}

	public void setWprice(int wprice) {
		this.wprice = wprice;
	}

	public String getWname() {
		return wname;
	}

	public void setWname(String wname) {
		this.wname = wname;
	}

	public String getWfrom() {
		return wfrom;
	}

	public void setWfrom(String wfrom) {
		this.wfrom = wfrom;
	}

	public String getWcontent() {
		return wcontent;
	}

	public void setWcontent(String wcontent) {
		this.wcontent = wcontent;
	}

	public String getWgroup() {
		return wgroup;
	}

	public void setWgroup(String wgroup) {
		this.wgroup = wgroup;
	}
	
	
	
	
	
}
