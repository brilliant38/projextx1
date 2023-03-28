package com.projectx3.board.service;

import java.util.List;

import com.projectx3.board.vo.BoardVO;
import com.webjjang.util.PageObject;

public interface BoardService {
	
	//요구에 대한 처리 기준
	public List<BoardVO> list(PageObject pageObject);
	
	public BoardVO view(long no, int inc);
	
	public int write(BoardVO vo);

	public int update(BoardVO vo);
	
	public int delete(BoardVO vo); //no, pw를 받아서 삭제.
	
}
