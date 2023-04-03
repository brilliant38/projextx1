package com.projectx3.image.service;

import java.util.List;

import com.projectx3.image.vo.ImageFileVO;
import com.projectx3.image.vo.ImageVO;
import com.webjjang.util.PageObject;

public interface ImageService {
	// 1. 리스트
	public List<ImageVO> list(PageObject pageObject);
	
	// 2. 이미지 보기 - 텍스트 정보 가져오기, 이미지 파일 가져오기
	public ImageVO view(long no);
	public List<ImageFileVO> viewFiles(long no);
	
	//3. 이미지 등록 - 텍스트 정보 등록, 이미지 등록
	public int write(ImageVO vo, List<ImageFileVO> list); // 먼저 시퀀스에서 글 번호를 받아서 vo.no에 세팅 처리해 주게 한다. select key 태그 이용
	
	//4. 이미지 수정 - 텍스트 정보 수정, 이미지 파일 수정, 대표 이미지 변경
	public int update(ImageVO vo);
	public int updateFile(ImageFileVO vo);
	public int updateFilePresident(long no, long fno);
	
	//5. 이미지 삭제 - 게시판의 글 삭제, 이미지 삭제
	public int delete(long no);
	public int deletefile(long fno);
}
