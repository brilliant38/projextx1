package com.projectx3.image.vo;

import lombok.Data;

@Data
public class ImageFileVO {
	
	private long no, fno; // 글 번호 : no, 글 내의 이미지 번호 fno
	private String fileName;
	private int president;
	
}
