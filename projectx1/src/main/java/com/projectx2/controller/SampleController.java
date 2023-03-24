package com.projectx2.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import lombok.extern.log4j.Log4j;

// uri - /sample/*
//자동 생성 어노테이션 - @Controller, @Service, @Repository, @Component, @RestController, @Advice
//@Controller - servlet-context.xml에 선언이 안되어 있으면 동작하지 않는다. 그 외 어노테이션은 root-context.xml에 선언
// mapping은 클래스 위에, 메소드 위에 -> 클래스 매핑 ==> 전체 uri에 해당이 된다.
@Controller
@RequestMapping("/sample/*" )
@Log4j
public class SampleController {
	
	//String  - redirect: 에 안 붙으면 jsp로 forward, redirect:이 붙어 있으면, 이동.
	//void면 uri가 jsp의 정보가 된다. ex) /sample/test -> /sample/test.jsp를 자동으로 찾는다.
	@RequestMapping("/basic") //uri -> /sample/basic
	public void basic() {
		log.info("basic........................");
	}
	
	//uri -> /sample/basicGet
	@RequestMapping(value ="/basicGet", method = RequestMethod.GET) 
	public void basicGet() {
		log.info("basicGet........................");
		
		
	}
	
	// @RequestMapping에서 Get방식만 받도록 정의해 놓은 어노테이션-> @GetMapping
	@GetMapping("/basicGet2")
	public void basicGet2() {
		log.info("basicGet2........................");
		
		
	}
}
