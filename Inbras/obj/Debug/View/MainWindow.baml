   M S B A M L   `   `   `  ����A  =Inbras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Inbras.ViewModelInbras.ViewModel  5   	       Inbras.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Inbras.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5	      *   $Inbras.ViewModel.MainWindowViewModel  5
   
    � 	Resources 5       �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value��%�   '��       �� 5   
   " ��6    5      �� 5       6   �� *Select_Department.Employee+ 6M   Z� .a�5      ��  � y�$ Hidden=�63   5      5      5      .��5      �� .+�5   
   �� ��6   Z� ��6$   �� *
Department+	 �� SelectedItem	 6G   �� *Select_Department+��5      �� 5      .R�5      �� ��6    �� *NameDepartment+5      5      �� 5   
   ��6   �� *Select_Department.Employee+��5      �� 5      .R�5       �� ��6    �� 
 �� Path$
 LastName�5!      5#      5$      5%      