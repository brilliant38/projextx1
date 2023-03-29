package com.projectx3.controller;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.projectx3.board.vo.BoardVO;
import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@RestController
@RequestMapping("/rest")
@Log4j
public class RestSampleController {
	
	@GetMapping(value= "/getText" , produces = "text/plain; charset=UTF-8")
	public String getTest() {
		return "안녕하세요.";
	}
	
	//xml --> <no>10</no><title>게시판입니다.</title>
	//JSON --> {no:10,title:"게시판입니다."}
	@GetMapping(value= "/getVO", 
				produces= {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE}) //json, xml 모두 적용하겠다.
	public BoardVO getVO() {
		BoardVO vo = new BoardVO();
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		return vo;
	}
	
	//xml --> <no>10</no><title>게시판입니다.</title>
	//JSON --> {no:10,title:"게시판입니다."}
	@GetMapping(value= "/getList", 
			produces= {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE}) //json, xml 모두 적용하겠다.
	public List<BoardVO> getList() {
		List<BoardVO> list = new ArrayList<BoardVO>();
		BoardVO vo = new BoardVO();
		BoardVO vo2 = new BoardVO();
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		vo2.setNo(9);
		vo2.setTitle("게시판2입니다.");
		list.add(vo2);
		
		return list;
	}
	
	//xml --> <no>10</no><title>게시판입니다.</title>
	//JSON --> {no:10,title:"게시판입니다."}
	@GetMapping(value= "/getMap", 
			produces= {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE}) //json, xml 모두 적용하겠다.
	public Map<String, Object> getMap() {
		List<BoardVO> list = new ArrayList<BoardVO>();
		BoardVO vo = new BoardVO();
		BoardVO vo2 = new BoardVO();
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		list.add(vo);
		vo2.setNo(9);
		vo2.setTitle("게시판2입니다.");
		list.add(vo2);
		
		PageObject pageObject = new PageObject();
		
		//list와 PageObject를 동시에 넘겨야 한다.
		Map<String, Object> map = new HashMap<String, Object>();
		map.put("list", list);
		map.put("pageObject", pageObject);
		
		return map;
	}
	
	//Ajax를 사용하다보면 내부에 오류가 있는지 정상적인 처리가 됐는지? -> 처리 상태를 알려주는 객체 - ResponseEntity 객체 사용
	@GetMapping(value="/check", params = {"height","weight"}) //params를 써줘도 되고, 안써줘도 log에 찍히는걸 보면 알아서 받아주는걸 알 수 있다.
	public ResponseEntity<BoardVO> check(Double height, Double weight) {
		log.info("height: " + height + ", weight: " + weight);
		
		//상태 체크 결과 객체 생성.
		ResponseEntity<BoardVO> result = null;
		BoardVO vo = new BoardVO();
		
		vo.setNo(10);
		vo.setTitle("게시판입니다.");
		
		//비정상, 정상 확인후 body는 뭔지 모름
		if(height < 150) {
			result = ResponseEntity.status(HttpStatus.BAD_GATEWAY).body(vo);
		} else {
			result = new ResponseEntity<BoardVO>(vo, HttpStatus.OK);
		}
		

		return result;
	}
	
}

















