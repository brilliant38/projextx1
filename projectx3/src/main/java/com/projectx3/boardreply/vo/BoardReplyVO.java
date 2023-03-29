package com.projectx3.boardreply.vo;

import java.util.Date;

import lombok.Data;
import lombok.Setter;

@Data
public class BoardReplyVO {
	
	private long rno, no;
	private String reply, replyer;
	private Date replyDate, updateDate;
	
}
