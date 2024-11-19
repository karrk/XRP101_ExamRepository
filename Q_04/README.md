# 4번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 1. Player
- 상태 패턴을 사용해 Idle 상태와 Attack 상태를 관리한다.
- Idle상태에서 Q를 누르면 Attack 상태로 진입한다
  - 진입 시 2초 이후 지정된 구형 범위 내에 있는 데미지를 입을 수 있는 적을 탐색해 데미지를 부여하고 Idle상태로 돌아온다
- 상태 머신 : 각 상태들을 관리하는 객체이며, 가장 첫번째로 입력받은 상태를 기본 상태로 설정한다.

### 2. NormalMonster
- 데미지를 입을 수 있는 몬스터

### 3. ShieldeMonster
- 데미지를 입지 않는 몬스터

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- AttackState 의 Attack 내 Getcomponent IDamagable 은 해당 인터페이스를 상속받지 않는 컴포넌트라면 Null Reference가 발생된다.
TryGetcomponent 를 사용해 이러한 문제를 해결할 수 있다.

- Attack 에서 행위를 종료할때 Exit 를 직접 호출하고 있다.
상태 전환시(ChangeState 메서드) 또한 Exit 를 호출하고 있으므로 서로 계속 Exit 작동시키므로 StackOverflow 가 발생된다. StateAttack 에서 Exit를 직접 호출하지 않고 원하는 종료시점에 상태를 Idle로 전환시켜주면 된다.
