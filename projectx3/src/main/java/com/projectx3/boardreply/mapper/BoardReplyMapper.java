package com.projectx3.boardreply.mapper;

import java.util.List;
import java.util.Map;

import com.projectx3.boardreply.vo.BoardReplyVO;

public interface BoardReplyMapper {

	public List<BoardReplyVO> list(Map<String, Object> map);
	public long getTotalRow(Map<String, Object> map);
	
	public int write(BoardReplyVO vo);

	public int update(BoardReplyVO vo);
	
	public int delete(Long rno);
	
}
