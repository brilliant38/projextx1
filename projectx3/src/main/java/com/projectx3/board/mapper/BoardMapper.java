package com.projectx3.board.mapper;

import java.util.List;

import com.projectx3.board.vo.BoardVO;
import com.webjjang.util.PageObject;

public interface BoardMapper {
	
	//DB처리 기준
	public List<BoardVO> list(PageObject pageObject);
	
	public Long getTotalRow(PageObject pageObject); //pageObject.setTotalRow() 처리해야 데이터를 가져온다.
	
	public BoardVO view(long no);
	
	public int increase(long no); //조회수 1증가 시키기위한 메소드
	
	public int write(BoardVO vo);
	
	public int update(BoardVO vo);
	
	public int delete(BoardVO vo); //no, pw를 받아서 삭제.
	
	

}
