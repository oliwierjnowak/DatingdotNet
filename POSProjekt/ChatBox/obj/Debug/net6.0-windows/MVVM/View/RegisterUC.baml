   M S B A M L   `   `   `  ����B  >ChatBox, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ChatBox.MVVM.ViewChatBox.MVVM.View  5      "    ChatBox.MVVM.View.RegisterUC   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ChatBox.MVVM.View     5      
�������.��5
      � -   5          �Name$  mygrid��5
      .+�5   
   �� -   5         ��Name$ Label��5      $��Register��6   $��Center=�62   $��0,83,0,0q�6O   $	��Top=�6a   �� 5   
   -   5         ��Name$ 
UsernameTB��5      $��Center=�6&   $��	0,147,0,0q�6C    �� TextWrapping$
 Wrap=�6V   $	��Top=�6�   $	��120��6�   ��6j   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ 
PasswordTB��5      $��Center=�6&   $��	0,188,0,0q�6C   $
 Wrap=�6V   $	��Top=�6�   $	��120��6�   ��6j   �� *
Password+$ PropertyChanged=�6�   �� 5   
   -   5        $ 
ImageURLTB��5      $��Center=�6&   $��	0,241,0,0q�6C   $
 Wrap=�6V   $	��Top=�6�   $	��120��6�   ��6j   �� *
ImageUrl+$ PropertyChanged=�6�   �� 5   
   $��139,135,502,84q�6   ��6+   �� *Images+$ PropertyChanged=�5      �� 5   
   -   5         ��Name$ ImageButton��5      $��	Add Image��6&   $
��Left=�6}   $��513,241,0,0q�6�   $	��Top=�6�   ��6:   �� *
AddImage+$ PropertyChanged=�6�   �� 5   
   -   5        $ RegisterButton��5      $��Register��6)   $
��Left=�6�   $��374,286,0,0q�6�   $	��Top=�6�   ��6<   �� *RegisterCommand+$ PropertyChanged=�5      5      5      