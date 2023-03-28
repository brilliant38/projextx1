package com.projectx3.board.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.projectx3.board.service.BoardService;
import com.projectx3.board.vo.BoardVO;
import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@Controller
@RequestMapping("/board")
@Log4j
public class BoardController {
	
	private String module = "board";
	
	@Autowired
	@Qualifier("boardServiceImpl") // @Qualifier 사용할 때는 @Autowired를 사용해서 DI 적용해 주세요.
	private BoardService service;
	
	@RequestMapping("/list.do")
	public String list(@ModelAttribute("pageObject") PageObject pageObject, Model model) { //@ModelAttribute로 "" 지정하여 가져올 객체명 입력
		log.info("게시판 리스트");
		model.addAttribute("list", service.list(pageObject));
		return module + "/list";
	}
	
	@RequestMapping("/view.do")
	public String view(long no , int inc, Model model) {
		log.info("게시판 글보기");
		model.addAttribute("vo", service.view(no, inc));
		return module + "/view";
	}
	
	@GetMapping("/write.do")
	public String writeForm() {
		log.info("게시판 글 쓰기 폼");
		return module + "/write";
	}
	
	@PostMapping("/write.do")
	public String write(BoardVO vo, long perPageNum, RedirectAttributes rttr) { 
		log.info("게시판 글 쓰기 처리");
		service.write(vo);
		rttr.addFlashAttribute("msg","글 등록이 되었습니다.");
		return "redirect:list.do?perPageNum=" + perPageNum;
	}
	
	@GetMapping("/update.do")
	public String updateForm(long no, Model model) {
		log.info("게시판 글 수정 폼");
		model.addAttribute("vo", service.view(no, 0));
		return module + "/update";
	}
	
	@PostMapping("/update.do")
	public String update(BoardVO vo, RedirectAttributes rttr) {
		log.info("게시판 글 수정 처리");
		service.update(vo);
		rttr.addFlashAttribute("msg","글 수정이 되었습니다.");
		return "redirect:view.do?no="+ vo.getNo() + "&inc=0";
	}
	
	@PostMapping("/delete.do")
	public String delete(BoardVO vo, RedirectAttributes rttr) {
		log.info("게시판 글 삭제");
		service.delete(vo);
		rttr.addFlashAttribute("msg","글 삭제가 되었습니다.");
		return "redirect:list.do";
	}
	
}
