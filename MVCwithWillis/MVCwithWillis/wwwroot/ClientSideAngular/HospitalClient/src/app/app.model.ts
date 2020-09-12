export class Patient{

    name : string = "";
    address : string = "";
    email : string = "";

    constructor(){
        
        this.name = "Mahima";
        this.address = "Nagpur";
        this.email = "mahimakpatel61@gmail.com";
    }

    problems:Array<PatientProblem> = new Array<PatientProblem>();

}

export class PatientProblem{

    id : number = 0;
    problem : string = "";
    genetic : boolean;
    
}