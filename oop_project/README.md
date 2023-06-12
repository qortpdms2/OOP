구현한 기능은 앞에 []로 감싸 표시하겠다. 
WinForm은 총 4개를 구현하였다.
MainForm, Login, sales_details, stock

MainForm은 포스기 메인 화면을 나타내는 폼
Login은 Login 하는 폼
sales_details는 판매 내역 폼
stock은 재고 관리 폼이다.

<Login.cs>
![image](https://github.com/qortpdms2/OOP/assets/128915671/911693bd-7e80-4b74-bbf9-b5c184d32f64)

[Login Form 배경화면 색상 변경] 1
[Y&R POS 로고 구현]2
[ID box 구현]3
- 내가 설정한 아이디 bse1을 입력하지 않으면 MessageBox.Show("아이디와 비밀번호를 확인해주세요.");를 이용하여 아이디를 다시 입력하게끔 유도한다.

[Password box 구현]4
- 내가 설정한 비밀번호 0822를 입력하지 않으면 MessageBox.Show("아이디와 비밀번호를 확인해주세요.");라는 창을 뜨게 한다. 

[Login 버튼]5
- 맞는 ID 값과 Password 값이 들어오면 
- ![image](https://github.com/qortpdms2/OOP/assets/128915671/5f927262-7f03-417c-8105-f06220341b00)
이라는 message를 보이게 한다.

Pos기 보이기 전에
![image](https://github.com/qortpdms2/OOP/assets/128915671/3238c2f7-89e7-4c8c-a96f-6c7f370d34b3)라는 message를 띄운다.

[종료 버튼]6
![image](https://github.com/qortpdms2/OOP/assets/128915671/0a46b1a3-9d50-4636-9567-24be7e9e5bf5)
- 빨간색 버튼을 누르면 시스템이 종료된다.

<포스기 메인 화면>
![image](https://github.com/qortpdms2/OOP/assets/128915671/52177520-d053-47bf-aac7-e47d6d7d328c)

[상품명 box, 가격 box, 개수 box, 합계 box 구현]7
- 주문받은 메뉴의 이름을 입력받는다.
- 주문받는 메뉴의 가격을 입력받는다.
- 주문받는 메뉴의 개수을 선택한다.
- 테이블에 있는 메뉴들의 총 값을 합계 box에 넣어 보여주는 창 구현

[담기 버튼 구현]8
- 위의 상품명, 가격, 개수, 합계 box의 값이 있는 상태로 '담기' 버튼을 클릭하면 해당 값들이 각 애트리뷰트에 맞게 저장되게 함.

[삭제 버튼]9
- 테이블의 행을 클릭한 상태로 '삭제' 버튼을 클릭하면 해당 행이 삭제되고, 삭제되면 합계 box의 값도 재할당된다.

[계산 버튼]10
- 계산 버튼을 클릭하면 현재 테이블에 저장돼있는 튜플들의 총 합을 보여준다.

[로그아웃 버튼]11
로그아웃 버튼을 누르면 로그인 폼이 뜸.

[판매내역 버튼, 재고현황 버튼]12
- 판매내역 또는 재고현황 버튼을 클릭하면 해당 포스기 폼은 닫히고, 판매내역 윈폼으로 이동한다.

![image](https://github.com/qortpdms2/OOP/assets/128915671/bab94ba5-57ef-41bd-ad11-e53f07a4107d)

[Home 버튼 구현]12
판매내역 winform, 재고현황 winform 둘 다에 구현한 버튼. Home 버튼을 클릭하면 '메인 홈으로 이동합니다.'는 알림이 뜨고 MainForm으로 이동한다. 즉 포스기의 메인 화면으로 이동





