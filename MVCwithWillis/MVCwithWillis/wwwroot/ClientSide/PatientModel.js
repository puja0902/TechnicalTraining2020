//model of javascript

function Patient() { //<--- Function, Constructor
    this.name = "";
    this.address = "";
    this.email = "";
    this.problems = [];
}

function PatientProblem() {
    this.problem = "";
    this.treatments = [];
}

function Treatment() {
    this.medicineName = "";
    this.numberOfTimesInDay = "";
}


