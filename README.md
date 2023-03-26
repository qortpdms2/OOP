# Report
<Stack.cs파일에 들어있는 클래스 설명>
1. ArrayStack namespace가 있습니다. 이 클래스 안에는 Array로 구현한 Stack 클래스, ArrayStack이 있습니다. 또한 같은 namespace 안에 Node 클래스도 있습니다. 
2. ArrayStack안에 정수형 배열 arr과 top의 index를 의미하는 topIndex가 멤버 변수로 있습니다. 멤버 함수는 push(), pop(), peek()가 구현돼있습니다. 
3. Node 클래스 안에는 push 되는 데이터를 의미하는 정수형 data변수, 다음 노드를 가리키는 next변수가 있습니다.
-> next 변수는 LinkedList를 위한 변수입니다. 이후에 설명하겠습니다.


<LinkedList.cs>
1. top 노드를 가리키는 변수 top이 멤버 변수로 있습니다. 멤버 함수는 push(), pop()이 있습니다. 
