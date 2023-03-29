package com.projectx3.boardreply.service;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.projectx3.boardreply.mapper.BoardReplyMapper;
import com.projectx3.boardreply.vo.BoardReplyVO;
import com.webjjang.util.PageObject;

import lombok.Setter;

// @Controller, @Service, @Repository, @Component, @RestController @Advice - 자동 생성을 위한 어노테이션. 각각의 역할 기억이 필요.
// root-context.xml, servlet-context.xml에 base-package로 선언
@Service
public class BoardReplyServiceImpl implements BoardReplyService {
	
	@Setter(onMethod_ = @Autowired )
	private BoardReplyMapper mapper;
	
	@Override
	public List<BoardReplyVO> list(PageObject pageObject, long no) {
		Map<String, Object> map = new HashMap<String, Object>();
		map.put("no", no);
		map.put("pageObject", pageObject);
		pageObject.setTotalRow(mapper.getTotalRow(map));
		
		return mapper.list(map);
	}

	@Override
	public int write(BoardReplyVO vo) {
		// TODO Auto-generated method stub
		
		return mapper.write(vo);
	}

	@Override
	public int update(BoardReplyVO vo) {
		// TODO Auto-generated method stub
		return mapper.update(vo);
	}

	@Override
	public int delete(Long rno) {
		// TODO Auto-generated method stub
		return mapper.delete(rno);
	}

}
