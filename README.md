
# nsis-installer-sample
<!--![배지 또는 로고 이미지 (선택사항)](링크)-->
<!--프로젝트에 대한 간단한 설명을 여기에 작성합니다.-->
Install Package NSIS를 이용한 설치프로그램(.exe)생성 샘플 Repository 입니다.


## 목차
- [nsis-installer-sample](#nsis-installer-sample)
  - [목차](#목차)
  - [소개](#소개)
  - [주의사항](#주의사항)
  - [사용법](#사용법)
<!--- [기여](#기여)
- [라이선스](#라이선스)
- [문의](#문의)
-->
## 소개
<!--프로젝트에 대한 자세한 설명을 여기에 작성합니다.  -->
- **필요프로그램** : [NSIS](https://nsis.sourceforge.io/Download),[ HM NIS Edit](http://hmne.sourceforge.net/)

- **주요기능** : 
  
   1. 응용 프로그램을 설치프로그램(installer)으로 패키지화
   2. 설치프로그램의 아이콘 변경
   3. 응용 프로그램의 레지스트리를 등록하여 URL스키마를 통해 웹에서 응용프로그램 호출 & 실행 

## 주의사항
NSIS 스크립트에 절대경로가 포함되어있기때문에 Repository를 하위 경로에 다운로드하거나,스크립트 내부의 설정 경로를 변경해야합니다.

	D:\


## 사용법

* [프로그램 설치 & 설치프로그램(installer)생성](https://build.tistory.com/27)
* [설치프로그램(installer) 아이콘 변경](https://build.tistory.com/33)
* [레지스트리를 등록하여 웹 URL로 응용프로그램 호출](https://build.tistory.com/35)
	
   샘플 HTML (**CallNsisSample.html**)파일로 URL 호출을 테스트 할 수 있습니다.
  ![image](https://github.com/user-attachments/assets/62467e83-2983-4ee9-a188-8c1e1903fe73)


