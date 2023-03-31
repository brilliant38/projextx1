package com.projectx3.boardreply.controller;

import java.io.UnsupportedEncodingException;
import java.net.URLEncoder;
import java.util.HashMap;
import java.util.Map;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.projectx3.boardreply.service.BoardReplyService;
import com.projectx3.boardreply.vo.BoardReplyVO;
import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@RestController
@RequestMapping("/boardreply")
@Log4j
public class BoardReplyController {
	
	@Autowired
	@Qualifier("boardReplyServiceImpl")
	private BoardReplyService service;
	
	
	@GetMapping(value = "/list.do", produces = {MediaType.APPLICATION_JSON_UTF8_VALUE, MediaType.APPLICATION_XML_VALUE})
	public ResponseEntity<Map<String, Object>> list(PageObject pageObject, long no) {
		log.info("댓글 리스트");
		log.info("pageObject = " + pageObject + ", no = " + no);
		Map<String, Object> map = new HashMap<String, Object>();
		
		map.put("list", service.list(pageObject, no));
		map.put("pageObject", pageObject);
		
		log.info("return map = " + map);
		
		return new ResponseEntity<Map<String,Object>>(map, HttpStatus.OK);
	}
	
	
	@PostMapping(value= "/write.do", consumes = "application/json",
			produces = {MediaType.TEXT_PLAIN_VALUE+";charset=utf-8"}) //리턴 타입과 맞춰줘야 한다.
	public ResponseEntity<String> write(@RequestBody BoardReplyVO vo, HttpSession session) {
		
		log.info(MediaType.TEXT_PLAIN_VALUE);
		
		//session에서 id를 꺼내야 한다.
		String id = "test";
		vo.setReplyer(id);
		
		log.info(vo);
		
		try {
			service.write(vo);
			//return이 간다는 것은 정상 처리가 되었다는 것이고, 안되었을 경우에는 jQuery에서 예외처리로 진행 됨.
			return new ResponseEntity<String>(URLEncoder.encode("댓글이 정상적으로 등록 되었습니다.", "utf-8") , HttpStatus.OK);
		} catch (UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return new ResponseEntity<String>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}

	

	@PostMapping(value= "/update.do", consumes = "application/json",
			produces = {MediaType.TEXT_PLAIN_VALUE+";charset=utf-8"}) //리턴 타입과 맞춰줘야 한다.
	public ResponseEntity<String> update(@RequestBody BoardReplyVO vo) {
		
		log.info(MediaType.TEXT_PLAIN_VALUE);
	
		log.info(vo);
		
		try {
			int result = service.update(vo);
			if(result == 1)
			//return이 간다는 것은 정상 처리가 되었다는 것이고, 안되었을 경우에는 jQuery에서 예외처리로 진행 됨.
			return new ResponseEntity<String>("댓글이 정상적으로 수정 되었습니다." , HttpStatus.OK);
			
			else
				return new ResponseEntity<String>("댓글의 정보를 확인해주세요. 새로고침해서 진행해 주세요." , HttpStatus.INTERNAL_SERVER_ERROR);
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return new ResponseEntity<String>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}

	@DeleteMapping(value= "/delete.do",
			produces = {MediaType.TEXT_PLAIN_VALUE+";charset=utf-8"}) //리턴 타입과 맞춰줘야 한다.
	public ResponseEntity<String> delete(long rno) {
		
		log.info(rno);
		
		try {
			int result = service.delete(rno);
			if(result == 1)
			//return이 간다는 것은 정상 처리가 되었다는 것이고, 안되었을 경우에는 jQuery에서 예외처리로 진행 됨.
			return new ResponseEntity<String>("댓글이 정상적으로 삭제 되었습니다." , HttpStatus.OK);
			
			else
				return new ResponseEntity<String>("댓글의 정보를 확인해주세요. 새로고침해서 진행해 주세요." , HttpStatus.INTERNAL_SERVER_ERROR);
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return new ResponseEntity<String>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}
}



















