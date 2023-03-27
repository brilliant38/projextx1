package com.projectx2.board.service;

import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import lombok.Setter;
import lombok.extern.log4j.Log4j;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration
@Log4j
public class BoardServiceTest {

		@Setter(onMethod_ = {@Autowired})
		private BoardServiceImpl service;
		
		@Test
		public void testExist() {
			log.info("\n서비스 테스트 -------------------------------");
			log.info(service);
		}
}
