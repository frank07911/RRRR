#include<iostream>
using namespace std;
main(){
	int i,n,x=0,y=0;	//x案计y计 
	cin>>n;				//块┮惠耞 
	for(i=1;i<=n;i++){	//眖1秨﹍n 
		if(i%2==0){		//耞"i"狦琌案计杠x++i 
			x=x+i;
		}
		else
			y=y+i;		//狦"i"ぃ琌案计玥y++i 
	}s
	cout<<"计羆"<<y<<endl;
	cout<<"案计羆"<<x<<endl; 
	return 0;
} 
