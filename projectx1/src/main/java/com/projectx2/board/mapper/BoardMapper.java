package com.projectx2.board.mapper;

import java.util.List;

import com.projectx2.board.vo.BoardVO;
import com.webjjang.util.PageObject;

public interface BoardMapper {
	
	public List<BoardVO> list(PageObject pageObject);
	
	public long getTotalRow(PageObject pageObject);

	public int increase(long no);
	
	public BoardVO view(long no);
	
	public int write(BoardVO vo);
	
	public int update(BoardVO vo);
	
	public int delete(BoardVO vo);

	
}
