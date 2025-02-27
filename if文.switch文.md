## 制御構文
### if文
if(条件式)
{

}
else if(条件式)
{

}
else
{

}
ifにヒットしなければelse if
どれにもヒットしなければelseに入る

### switch文
switch(変数)
{
    case xx:
        break;
    case ss:
        break;
    default:
        break;
}
case xxならyy。
breakは必ず必要。最後はdefaultで極力書いた方が良い。

### if文例文
int value = Convert.ToInt32(textBox1.Text);
if(value == 10){
    MessageBox.Show("10です");
}
// 上の条件にヒットしない場合は以下に進む
// elseにしておかないと無駄に読み込まれる
else if(value == 20){
    MessageBox.Show("20です");
}
else if(value == 30){
    MessageBox.Show("30です");
}
else{
    MessageBox.Show("どれでもない");
}

### switch 例文
switch(value){
    case 10:
        // valueが10なら10を表示
        MessageBox.Show("10です。");
        break;
    case 11:
        // valueが11なら11を表示
        MessageBox.Show("11です。");
        break;
    case 12:
        // valueが12なら12を表示
        MessageBox.Show("12です。");
        break;    
    default:
        // どれでもないなら
        MessageBox.Show("どれでもない");
        break;
}