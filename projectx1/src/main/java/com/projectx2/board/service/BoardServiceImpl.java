package com.projectx2.board.service;

import java.util.List;

import javax.inject.Inject;

import org.springframework.stereotype.Service;

import com.projectx2.board.mapper.BoardMapper;
import com.projectx2.board.vo.BoardVO;

@Service
public class BoardServiceImpl {
	
	@Inject
	private BoardMapper mapper;
	
	public List<BoardVO> list() {
		return mapper.list();
	}
	public BoardVO view(long no, int inc) {
		if(inc==1) mapper.increase(no);
		return mapper.view(no);
	}
	public int write(BoardVO vo) {
		return mapper.write(vo);
	}
	public int update(BoardVO vo) {
		return mapper.update(vo);
	}
	public int delete(BoardVO vo) {
		return mapper.delete(vo);
	}
}
