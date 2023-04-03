package com.projectx3.image.controller;

import java.awt.Image;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
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
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.projectx3.image.service.ImageService;
import com.projectx3.image.vo.ImageFileVO;
import com.projectx3.image.vo.ImageVO;
import com.webjjang.util.PageObject;
import com.webjjang.util.file.FileUtil;

import lombok.extern.log4j.Log4j;

@Controller
@RequestMapping("/image")
@Log4j
public class ImageController {
	
	String modul = "image";
	String path = "/upload/image2";
	
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
	public String write(ImageVO vo,int president, MultipartFile[] imageFile, HttpSession session, HttpServletRequest request, RedirectAttributes rttr) throws Exception {
		log.info("이미지 게시판 등록........................................................");
		
		//file 정보들을 저장하는 list --> fileName, president
		List<ImageFileVO> list = new ArrayList<ImageFileVO>();
		
		//session에서 ID를 가져온다. -> 하드코딩
		vo.setId("test");

		log.info("vo= " + vo);
		log.info("president= " + president);
		
		for(int i=0; i<imageFile.length; i++) {
			MultipartFile mfile = imageFile[i];
				log.info("---------------------------------------------------");
				log.info("name: " + mfile.getOriginalFilename());
				log.info(mfile.isEmpty());
				log.info("size: " + mfile.getSize());
				if(!mfile.isEmpty()) {
					ImageFileVO ifVO = new ImageFileVO();
					ifVO.setFileName(FileUtil.upload(path, mfile, request));  //경로에 파일이 없거나, 요청 오류거나 등등
					ifVO.setPresident((i==president)?1:0); //대표 이미지면 1 아니면 0으로 세팅
					list.add(ifVO);
				}
		}
		
		log.info(list); //imageFileVO가 들어있다.
		
		//DB에 저장 처리
		service.write(vo, list);
		
		rttr.addFlashAttribute("msg", "파일 등록이 되었습니다.");
		
		//이미지 업로드 시간이 있어서, list 화면으로 바로 돌아가는 경우 이미지 표시가 바로 안되는 경우가 있음.
		//이 시간을 벌기위한 처리를 해준다.
		Thread.sleep(500);
		
		return "redirect:list.do";
	} //write()끝
	
	@RequestMapping("/view.do")
	public String view(Long no, Model model) {
		
		log.info("이미지 게시판 글보기...................................................................");
		
		model.addAttribute("vo",service.view(no));
		model.addAttribute("list",service.viewFiles(no));
		
		return modul + "/view"; //view.jsp로 가자
	}
	
	//이미지 게시판 텍스트 정보만 수정하는 폼
	@GetMapping("/update.do")
	public String updateForm(long no, Model model) {
		
		log.info("이미지 게시판 수정 폼.............................");
		
		model.addAttribute("vo",service.view(no));
		
		return modul + "/update";
	}
	
	//이미지 게시판 텍스트 정보만 수정 처리
	@PostMapping("/update.do")
	public String update(ImageVO vo, PageObject pageObject, RedirectAttributes rttr) {
		
		log.info("이미지 게시판 수정 처리.............................");
		
		int result = service.update(vo);
		
		
		return "redirect:view.do?no=" + vo.getNo() + 
				"&page=" + pageObject.getPage() + 
				"&PerpageNum=" +pageObject.getPerPageNum() +
				"&key="+ pageObject.getKey() + 
				"&word="+ pageObject.getWord();
	}
}
