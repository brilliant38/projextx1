package com.projectx3.image.vo;

import java.util.Date;

import lombok.Data;

@Data
public class ImageVO {

	private long no;
	private String title, content, id, name;
	private Date writeDate;
	private String fileName; //대표 이미지 파일명 - 리스트 할 때 필요하다.
	
	
}
