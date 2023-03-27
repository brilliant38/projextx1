package com.projectx2.board.service;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import com.projectx2.board.mapper.BoardMapper;
import com.projectx2.board.vo.BoardVO;

import lombok.Setter;
import lombok.extern.log4j.Log4j;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration("file:src/main/webapp/WEB-INF/spring/root-context.xml")
@Log4j
public class BoardMapperTest {

		@Setter(onMethod_ = {@Autowired})
		private BoardMapper mapper ;
		
		@Test
		public void testExist() {
			log.info("\nmapper 리스트 테스트 -------------------------------");
			log.info(mapper.list());
		}
		
		@Test
		public void testView() {
			log.info("\nmapper 글보기 테스트 -------------------------------");
			long no = 1;
			log.info(mapper.view(no));
		}
		
		@Test
		public void testWrite() {
			log.info("\nmapper 글등록 테스트 -------------------------------");
			BoardVO vo = new BoardVO();
			vo.setTitle("테스트 제목");
			vo.setContent("테스트 내용");
			vo.setWriter("테스트 작성자");
			vo.setPw("1111");
			
			log.info(mapper.write(vo));
		}
		
}
