package com.projectx3.image.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;

import com.projectx3.image.mapper.ImageMapper;
import com.projectx3.image.vo.ImageFileVO;
import com.projectx3.image.vo.ImageVO;
import com.webjjang.util.PageObject;

import lombok.Setter;

@Service
@Qualifier("imageServiceImpl")
public class ImageServiceImpl implements ImageService {
	
	@Setter(onMethod_ = @Autowired)
	private ImageMapper mapper;
	
	@Override
	public List<ImageVO> list(PageObject pageObject) {
		// TODO Auto-generated method stub
		//setTotalRow를 호출하지 않으면 계산이 안되서 데이터를 가져오지 못한다.
		pageObject.setTotalRow(mapper.getTotalRow(pageObject));
		return mapper.list(pageObject);
	}

	@Override
	public ImageVO view(long no) {
		// TODO Auto-generated method stub
		return mapper.view(no);
	}

	@Override
	public List<ImageFileVO> viewFiles(long no) {
		// TODO Auto-generated method stub
		return mapper.viewFiles(no);
	}

	@Override
	public int write(ImageVO vo, List<ImageFileVO> list) {
		// TODO Auto-generated method stub\
		mapper.write(vo); //처리가 끝나면 no가 세팅이 되어 있음.
		for(ImageFileVO ifvo : list) {
			ifvo.setNo(vo.getNo()); 
			mapper.writeFile(ifvo);
		}
		return 1;
	}

	@Override
	public int update(ImageVO vo) {
		// TODO Auto-generated method stub
		return mapper.update(vo);
	}

	@Override
	public int updateFile(ImageFileVO vo) {
		// TODO Auto-generated method stub
		return mapper.updateFile(vo);
	}

	@Override
	public int updateFilePresident(long no, long fno) {
		// TODO Auto-generated method stub
		mapper.updateFileUnPresident(no);
		return mapper.updateFilePresident(fno);
	}

	@Override
	public int delete(long no) {
		// TODO Auto-generated method stub
		return mapper.delete(no);
	}

	@Override
	public int deletefile(long fno) {
		// TODO Auto-generated method stub
		return mapper.deletefile(fno);
	}

}
