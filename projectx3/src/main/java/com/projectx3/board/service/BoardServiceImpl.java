package com.projectx3.board.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

import com.projectx3.board.mapper.BoardMapper;
import com.projectx3.board.vo.BoardVO;
import com.webjjang.util.PageObject;

import lombok.Setter;

@Service
@Qualifier("boardServiceImpl")
public class BoardServiceImpl implements BoardService{
	
	@Setter(onMethod_ = {@Autowired})
	private BoardMapper mapper;

	@Override
	public List<BoardVO> list(PageObject pageObject) {
		//settotalrow 안에 startrow, endrow를 계산하는 처리가 있다. 안하면 데이터를 가져오지 않는다.
		pageObject.setTotalRow(mapper.getTotalRow(pageObject));
		return mapper.list(pageObject);
	}

	@Override
	public BoardVO view(long no, int inc) {
		if(inc == 1) mapper.increase(no);
		return mapper.view(no);
	}

	@Override
	public int write(BoardVO vo) {
		return mapper.write(vo);
	}

	@Override
	public int update(BoardVO vo) {
		return mapper.update(vo);
	}

	@Override
	public int delete(BoardVO vo) {
		return mapper.delete(vo);
	}

}
