# [완료]개인과제_ATM 시스템 만들기

---
### 🐾To improve : 
- **ScriptableObjects 사용해보자 !**

---
### ✨Things i did :
- 필수요구사항
  - ✅ ATM 화면 구성
    - Title / 이름 / 잔액(Balance) - 기본 50,000 원 / 현금 - 기본 100,000 원 / 입금 버튼 → 입금 기능으로 이동 / 출금 버튼 → 출금 기능으로 이동<br>
      ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/7e5789e5-d92c-47b5-906e-e4bbfe29d418)

  - ✅ 입금 기능
    - 입금 화면 UI 구성<br>
      ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/60796a90-5e14-4c7a-a383-3f906e493360)
    - 버튼을 누르면 해당 금액 만큼 현금에서 잔액으로 이동
    - 직접 입력을 이용하면 입력한 금액만큼 입금
    - 뒤로가기 버튼을 누르면 첫 화면으로 이동
    - 잔액이 부족하면 팝업 띄우기<br>
      ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/04cd7ce0-35d7-4d01-a95c-a9511a34ce4f)
    
  - ✅ 출금 기능
    - 출금 화면 UI 구성<br>
      ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/72eef750-c895-4665-9466-904df0d2d5a7)
    - 버튼을 누르면 해당 금액 만큼 잔액에서 현금으로 이동
    - 직접 입력을 이용하면 입력한 금액만큼 출금
    - 뒤로가기 버튼을 누르면 첫 화면으로 이동
    - 잔액이 부족하면 팝업 띄우기<br>
      ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/c5d9eeb6-d75b-477c-8d63-cb3ef02a5a3a)

- 선택요구사항
  - ✅ 통화 단위 적용
    - 1000 의 자리 마다 , 표시
      - 천 단위마다 쉼표 표시를 위해 `CashText.text = updatedCash.ToString("N0");` 를 사용해 구현했다.<br>
      이 외에도<br>
      `CashText.text = updatedCash.ToString("#,##0");`,<br>
      `CashText.text = string.Format("{0:#,###}", updatedCash);` 방식도 존재함을 새롭게 배웠다.
        
  - ✅ 금액 입력시 숫자만 입력
    - Input Field 에 숫자외에 입력 안되게 적용
      - unity 에서 Input Field 의 Inspector 창을 보면 Content Type 이 있는데, Integer Number 로 설정해서 Input Field 안에 숫자(int)만 입력할 수 있도록 만들었다.<br>
        ![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/c843e7ac-f334-4479-b1d2-74f31217a413)

---
### 📌TO-DOs :
- **ScriptableObjects 사용해보자 !**
- 선택요구사항
  - ⬜ 로그인 기능
  - ⬜ 회원가입
  - ⬜ 송금 기능

---
### 과제 제출을 하며(a.k.a. 회고)
아직 UI 를 다루는 것이 익숙하지 않아서<br>
두 가지 개인과제(ATM, 스파르타 던전 - Unity 버전) 중 난이도가 비교적 쉬운 ATM 시스템 만들기에 도전했다.

이번 과제를 진행하면서 고난 이슈가 한 번 찾아왔었는데(바로 어제 !),<br>
결론부터 말하자면 나의 치명적인 실수에서 비롯된 것이었고 무사히 해결했다.<br>
팝업창을 띠우는 부분에서 문제가 발생했었는데<br>
분명 로직적으로는 아무 문제가 없는데 팝업창이 뜨질 않아서 매우 당황스러웠고, 어제 하루종일 이 문제를 해결하기 위해 고군분투했다.<br>
저녁까지 해결하지 못해서 일단 밥먹고 TIL 작성하면서 뇌에게 잠시 휴식시간을 주고 밤에 재도전을 했다.<br>
이번에는 unity 를 하나씩 꼼꼼하게 체크해봤는데, 여기서 나의 치명적인 실수를 발견했다.

![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/cfad2b38-dae8-4111-8bcf-924432aeaf84)
![image](https://github.com/chochozane/PersonalProject_ATM/assets/130233619/1c46c45e-67c5-4eab-8bfd-8dfb90a85efb)<br>
ATMManager.cs - PopupMsgUI 에 PopupCanvas 를 넣었어야 했는데 Canvas 의 자식이었던 PopupMsgUI 를 넣어놨었다.<br>
부모인 PopupCanvas 를 계속 SetActive(false) 로 해둔 상태에서 진행하니 자식이 아무리 SetActive(true)가 되어도 팝업창이 안 보였던 것이었다..<br>
그리고 object 를 넣는 곳의 이름을 PopupMsgUI 라고 지어놔서 더더욱 헷갈리지 않았을까 싶다.<br>
해결을 해서 너무나도 기쁘고 감사하고 정말 귀한 경험을 했다..!

그래도 다행히 이번에도 첫 제출날짜에 무사히 필수요구사항을 모두 완료하고 제출할 수 있어서 뿌듯하다.<br>

그동안 개인 & 팀 과제를 진행해오면서 받았던 피드백을 바탕으로 이번 과제를 작업할 때 신경써서 체크한 부분들은 다음과 같다.
- git commit 을 자주하고, 내용을 명확하고 직관적으로 작성하기
- 사용하지 않는 이벤트 함수와 using 문들은 지워주는 습관 만들기
- 유니티 상에서 폴더링 챙기기(e.g. Scripts 폴더 안에 여러 하위 폴더들을 만들어서 script 들 정리하기)

해설강의가 올라오면 참고해서 남은 선택요구사항도 구현해보는 것을 목표로 하고 있다 !<br>
-> ***ScriptableObjects 사용해서 구현해보자 !***

---
🤎🥨
