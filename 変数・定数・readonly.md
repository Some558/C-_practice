### 変数の宣言と代入
string firstName;
firstName = "Bob";
以下の形でも良い
string firstName = "Bob";

### 曖昧な型
var message = "Hello World!";
varは必ず初期化された値が必要。

### 定数
const int AAA = 10;

### static readonly
ユーザーの要求、社会制度の変化、開発者の都合などで将来変更される可能性のある値を定数として公開する場合には、constキーワードではなくstatic readonlyを使うようにすべき