package com.projectx3.image.controller;

import java.awt.Image;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.multipart.MultipartFile;

import com.projectx3.image.service.ImageService;
import com.projectx3.image.vo.ImageVO;
import com.webjjang.util.PageObject;

import lombok.extern.log4j.Log4j;

@Controller
@RequestMapping("/image")
@Log4j
public class ImageController {
	
	String modul = "image";
	
	@Autowired
	@Qualifier("imageServiceImpl")
	private ImageService service;
	
	@RequestMapping("/list.do")
	public String list(@ModelAttribute PageObject pageObject, Model model) {
		
		log.info("이미지 게시판 리스트...................................................................");
		
		//이미지를 가져오는 갯수를 12개로 세팅해둔다
		pageObject.setPerPageNum(12);
		
		model.addAttribute("list", service.list(pageObject));
		
		return modul + "/list"; //list.jsp로 가자
	}
	
	//이미지를 선택해서 보내주는 처리
	@GetMapping("/write.do")
	public String writeForm() {
		return modul + "/write";
	}
	
	// 이미지를 받아서 처리
	@PostMapping("/write.do")
	public String write(ImageVO vo,int president, MultipartFile[] imageFile, HttpSession session) {
		log.info("이미지 게시판 등록........................................................");
		
		
		//session에서 ID를 가져온다. -> 하드코딩
		vo.setId("test");

		log.info("vo= " + vo);
		log.info("president= " + president);
		
		for(MultipartFile mfile : imageFile) {
				log.info("---------------------------------------------------");
				log.info("name: " + mfile.getOriginalFilename());
				log.info("size: " + mfile.getSize());
		//if(mfile.getOriginalFilename() != null && !mfile.getOriginalFilename().equals("") ) {
		//}
		}
		return "redirect:list.do";
	}
}
