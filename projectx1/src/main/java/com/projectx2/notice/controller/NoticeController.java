package com.projectx2.notice.controller;

import java.util.ArrayList;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import com.projectx2.notice.vo.NoticeVO;

import lombok.extern.log4j.Log4j;

//자동 생성 어노테이션 - @Controller, @Service, @Repository, @Component, @RestController, @Advice
//@Controller - servlet-context.xml에 선언이 안되어 있으면 동작하지 않는다. 그 외 어노테이션은 root-context.xml에 선언
@Controller
@RequestMapping("/notice")
@Log4j
public class NoticeController {
	
	String modul = "notice"; 
	
	@RequestMapping("/list.do")
	public String list() {
		log.info("공지사항 리스트 입니다....................");
		return modul + "/list";
	}
	
	@GetMapping("/view.do")
	public String view(long no, int inc) { //get으로 넘긴 변수와 동일하게 받는다.
		log.info("공지사항 글보기 입니다....................");
		log.info("no={"+ no + "}, inc={" + inc + "}");
		return modul + "/view";
	}
	
	@GetMapping("/write.do")
	public String writeForm() {
		log.info("공지사항 글쓰기폼 입니다....................");
		return modul + "/write";
	}
	
	@PostMapping("/write.do")
	public String write(NoticeVO vo) {
		log.info("공지사항 글쓰기 처리 입니다....................");
		log.info(vo);
		return "redirect:list.do";
	}
	
	@GetMapping("/update.do")
	public String updateForm() {
		log.info("공지사항 글수정 폼 입니다....................");
		return modul + "/update";
	}
	
	@PostMapping("/update.do")
	public String update() {
		log.info("공지사항 글수정 처리 입니다....................");
		return "redirect:view.do?no=10&inc=1";
	}
	
	@PostMapping("/delete.do")
	//@RequestParam([name, defaultValue, required, value]) - 넘어오는 데이터의 이름이 변수와 다른경우 , 값이 넘어오지 않는 경우 기본 값. 필수항목, 값세팅
	//여러개의 데이터를 받을 때 리스트로 받으면 클래스를 사용해야 한다.
	//public String delete(long[] no) {//배열로 받으면 값을 여러개 받을 수 있음.
	public String delete(@RequestParam("no") ArrayList<Long> no) {//List로 받으려면 어노테이션이 있어야 함.
		log.info("공지사항 글삭제 처리 입니다....................");
		//log.info(Arrays.toString(no));
		log.info(no);
		return "redirect:list.do";
	}
	
}
