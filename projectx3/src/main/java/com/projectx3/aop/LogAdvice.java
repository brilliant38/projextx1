package com.projectx3.aop;

import java.util.Arrays;

import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.Around;
import org.aspectj.lang.annotation.Aspect;
import org.springframework.stereotype.Component;

import lombok.extern.log4j.Log4j;

@Aspect //AOP 생성 어노테이션
@Log4j
@Component
public class LogAdvice {
	
	//AOP로 동작할 메소드 작성.
	@Around("execution(* com.projectx3.*.service.*ServiceImpl.*(..))") //Join Point Cut
	public Object logTime(ProceedingJoinPoint pjp) {
		long start = System.currentTimeMillis();
		
		//Before
		log.info("\n+========================================================================================");
		
		// 실행 되는 클래스
		log.info("* 실행 객체: " + pjp.getTarget());
		log.info("* 실행 메소드: " + pjp.getSignature());
		
		// 넘어가는 데이터
		log.info("* 전달 데이터: " + Arrays.toString(pjp.getArgs()));
		
		//처리하는 내용.
		//처리 결과 저장 객체
		Object result = null;
		
		try {
			result = pjp.proceed();
		} catch (Throwable e) {
			e.printStackTrace();
		}
		
		//After
		log.info("* 처리 결과 데이터: " + result);
		
		long end = System.currentTimeMillis();
		
		log.info("TIME: " + (end - start));
		
		log.info("\n+========================================================================================");
		
		return result;
	}
}
