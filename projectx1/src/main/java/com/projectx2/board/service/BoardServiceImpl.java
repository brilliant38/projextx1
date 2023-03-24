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
}
