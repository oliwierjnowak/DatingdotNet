   M S B A M L   `   `   `  ����B  >ChatBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ChatBox.MVVM.ViewChatBox.MVVM.View  5      "    ChatBox.MVVM.View.FeedbackUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ChatBox.MVVM.View     5      .��5	      �   � ColumnDefinitions  5   
   �� 5      $	��140 �6   �� 5      .+�5   
   � 
�������$��1��6"   .+�5      �� -   5         ��Name$ 
FeedbackTB��5      $
��Left=�6o   $��
165,97,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��391��6�   $	��190��6�   ��6*   �� *FeedbackString+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��Write your Feedback��6   $
��Left=�62   $��
290,65,0,0q�6M   $	��Top=�6a   �� 5      $
��Send��6   $
��Left=�6D   $��345,355,0,0q�6_   $	��Top=�6t   ��6$   �� *SendCommand+6t   5      5      5      