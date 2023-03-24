package com.projectx2.notice.vo;

import java.util.Date;

import org.springframework.format.annotation.DateTimeFormat;

import lombok.Data;

@Data
public class NoticeVO {
	
	private long no;
	private String title, content;
	// 받는 데이터는 String으로 들어와서 오류가 난다. -> 데이터 바인딩 어노테이션을 써야한다. @DateTimeFormat
	@DateTimeFormat(pattern = "yyyy-MM-dd") //SimpleDateFormat 클래스와 동일한 포맷.
	private Date startDate, endDate;
	private Date writeDate, updateDate;
	
}
  