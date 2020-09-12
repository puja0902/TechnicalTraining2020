export interface ICustomer{

    Add();
}


export class Customer implements ICustomer{
    
    customerName : string = ""; 
    customerAmount : number = 0;
    
    constructor(){

        this.customerName = "";
        this.customerAmount=0;
        
    }

    Add(){

    }
}

class CustomerChild extends Customer implements ICustomer{

    Add(){}
}