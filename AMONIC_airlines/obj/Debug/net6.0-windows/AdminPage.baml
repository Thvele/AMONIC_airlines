   M S B A M L   `   `   `  ????J  FAMONIC_airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AMONIC_airlinesAMONIC_airlines  5   	       AMONIC_airlines.AdminPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AMONIC_airlines     5   	     ? Title$'  !AMONIC Airlines Automation System??5   	   $	??600??63   $	??600??6@   $	??600??6P   $	??700??6`   $	??700??6l   $	??700??6{    ? 
ResizeMode$ NoResize=?6?      mainWindowFont#??[  6?   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??30 ?6   ?? 5      .+?5   
   c? $	??Top=?6   
???????.@?5      ?? $/??)Добавить пользователя??6   $??12(?65   ?? 5      -   5        $??
Выйти??5      $??12(?6%   63   5      ? 5   
   $??1??6   $??10,10,10,15q?6    5      ?? 5      $??0.07* ?6    ?? 5      ?? 5      $
??0.1* ?6    .+?5      ??  ?? Orientation$ 
Horizontal=?6   $??0??62   .+?5      ?? $??
Офис: ??6   $??0,0,5,0q?6*   $??Center=?6;   ?? 5      $	??200??6   
???????.@?5      ?? $??Все офисы??6#    ?? 
IsSelected$
 True??67   
???????6I   5      5       &   System.Windows.Controls.DataGrid  5!      -   5        $??dg_users??5!      $??1??6(   $??0,10,0,0q?65      AutoGenerateColumns$ False??6G      Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ?? 	 ?? Path$
	 Name?  5$      $ Фамилия??6)    6:   ?? $	 LastName?  5%      $ Возраст??6)    6:   ?? $		 Age?  5&      $ Роль??6)    67   ?? $
	 Role?  5'      $ 
Почта??6)    68   ?? $	 EmailAddress?  5(      $ Офис??6)    67   ?? $	 Office?4  .System.Windows.Controls.DataGridCheckBoxColumn  5)      $ Active??6-   
   
Visibility$
 Hidden=?6]    6=   ?? $	 Active?6]      RowStyle 5,      ?? 5-       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6    ?? Triggers 5.      ?? 5/       ?? Binding 6*   ?? *Role+ ?? Value Administrator6C   .a?50   "   ??  ?? Property ? ?? ?? Value
 ?????6?   51      ?? 52       6*   ?? *Active+	 false6E   .a?53   "   ??  ? ??
 ?  ??6?   54      56      58      ?? 5:      $ 
Horizontal=?6   $??2??66   .+?5;      ?? $??Изменить роль??6   $??30??61   $??0,0,60,0q?6=   $??	10,0,10,0q?6O   
???????6c   ?? 5<      -   5        $??
btn_unLock??5<      $@??:Включить/Выключить авторизацию??6+   $??30??6T   $??	10,0,10,0q?6`   
???????6?   5=      5?      5A      5B      