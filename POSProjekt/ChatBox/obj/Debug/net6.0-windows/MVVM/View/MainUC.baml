   M S B A M L   `   `   `  ����B  >ChatBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ChatBox.MVVM.ViewChatBox.MVVM.View  5          ChatBox.MVVM.View.MainUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ChatBox.MVVM.View     5      .��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ 	sidePanel��5      ���	#FF0F4E7A$
��Left=�6D   $��40��6_   .+�5      � $��50��6   
�������.+�5      �� -   5        $
��Left=�5      $��40��68   $	��Top=�6D   
������ 
������ .��5      �� $
��Home��6$   $��20��60   $��50��6<   5      5      �� 5      $��Disabled=�6   $��Century Gothic)�6Q   $��14(�6m   
�������
������ 
������ $
��Bold"�6�   .@�5      �� $��30��6#   .��5      ��  �� Orientation$ 
Horizontal=�6%   ���	#FF0F4E7A.+�5      �� -   5        
������ 
������ .��5   "   �� $��30 0 0 0q�6,   $��Swipe��6>   $��Center=�6K   
�������6f   5      5!      5"      �� 5#      $��30��6#   .��5$      �� $ 
Horizontal=�6%   .+�5%      �� -   5        
������ 
������ .��5&   "   �� $��30 0 0 0q�6,   $��Inbox��6>   $��Center=�6K   
�������6f   5'      5)      5*      �� 5+      $��30��6#   .��5,      �� $ 
Horizontal=�6%   .+�5-      �� -   5        
������ 
������ .��5.   "   �� $��30 0 0 0q�6,   $��Feedback��6>   $��Center=�6N   
�������6i   5/      51      52      56      57      � 59      -   5         �Name$ maingrid��59      .+�5<      ]� -   5         ]�Name$ sideDockPanel��5<      $	��200��63   $��40,0,0,0q�6?   $
��Left=�6Q   .+�5=      �� $��25��6   $	��Top=�5>       �� 
IsReadOnly$
 True��5@      ��5?      �� *CurrentUser.Username+ �� UpdateSourceTrigger$ PropertyChanged=�5@      �� 5C      ��6   �� *	ChatUsers+$ PropertyChanged=� �� SelectedItem 6`   ��  �� Path$ SelectedUser�$ PropertyChanged=���5D      �� 5E      .R�5F      �� ��6$   �� *
Username+$ PropertyChanged=�6f   5G      5I      5J      �� 5M   
   $��Right=�6   .+�5N      �� $	��380��6   ��5O      �� *ChatMessages+�� 5Q      $ 
Horizontal=�6   .+�5R      �� $��85��6   $	��560��5S      $��Center=�5T      ��5U      �� *	Message+$ PropertyChanged=��� 5V      $��55��6   $
��Send��5W      ��5X      �� *SendMessageCommand+5Y      5\      5]      5^      5_      5a      