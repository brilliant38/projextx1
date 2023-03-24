package com.projectx2.image.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.multipart.MultipartFile;

import lombok.extern.log4j.Log4j;

//자동 생성 어노테이션 - @Controller, @Service, @Repository, @Component, @RestController, @Advice
//@Controller - servlet-context.xml에 선언이 안되어 있으면 동작하지 않는다. 그 외 어노테이션은 root-context.xml에 선언
@Controller
@RequestMapping("/image")
@Log4j
public class ImageController {
	
	String modul = "image";
	
	
	// 이미지를 선택해서 보내주는 처리
	@GetMapping("/write.do")
	public String writeForm() {
		
		return modul + "/write";
	}
	
	// 이미지를 받아서 처리
	@PostMapping("/write.do")
	public String write(String title, MultipartFile[] files) {
		log.info(title);
		for(MultipartFile mfile : files) {
			if(mfile.getOriginalFilename() != null && !mfile.getOriginalFilename().equals("") ) {
			log.info("name: " + mfile.getOriginalFilename());
			log.info("size: " + mfile.getSize());
			log.info("---------------------------------------------------");
			}
		}
		return "redirect:list.do";
	}
	
}
