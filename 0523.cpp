#include<iostream>
using namespace std;
main(){
	int i,n,x=0,y=0;	//x������y���_�� 
	cin>>n;				//��J�һݧP�_���� 
	for(i=1;i<=n;i++){	//�q1�}�l��n 
		if(i%2==0){		//�P�_"i"�p�G�O���ƪ���x++i 
			x=x+i;
		}
		else
			y=y+i;		//�p�G"i"���O���ƫhy++i 
	}s
	cout<<"�_���`"<<y<<endl;
	cout<<"�����`"<<x<<endl; 
	return 0;
} 
