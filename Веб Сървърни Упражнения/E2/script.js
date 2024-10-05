let people = [];

class Person {
    constructor(name, age, gender) {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    introduce() {
        return `Hi, my name is ${this.name}, I am ${this.age} years old, and I am ${this.gender}.`;
    }
}

class Employee extends Person {
    constructor(name, age, gender, jobTitle, salary, department) {
        super(name, age, gender);
        this.jobTitle = jobTitle;
        this.salary = salary;
        this.department = department;
    }

    work() {
        return `My job title is ${this.jobTitle}, I work in the ${this.department} department, and my salary is $${this.salary}.`;
    }
}

class Student extends Person {
    constructor(name, age, gender, university, major, faculty) {
        super(name, age, gender);
        this.university = university;
        this.major = major;
        this.faculty = faculty;
    }

    study() {
        return `I study at ${this.university}, majoring in ${this.major}, and I am part of the ${this.faculty} faculty.`;
    }
}

// Show/hide input fields based on selected type
function toggleFields() {
    const type = document.querySelector('input[name="type"]:checked').value;
    const employeeFields = document.getElementById("employeeFields");
    const studentFields = document.getElementById("studentFields");

    if (type === "employee") {
        employeeFields.style.display = "block";
        studentFields.style.display = "none";
    } else {
        employeeFields.style.display = "none";
        studentFields.style.display = "block";
    }
}

function addPerson() {
    const name = document.getElementById("name").value;
    const age = document.getElementById("age").value;
    const gender = document.getElementById("gender").value;
    const type = document.querySelector('input[name="type"]:checked').value;

    let newPerson;

    if (type === "employee") {
        const jobTitle = document.getElementById("jobTitle").value;
        const salary = document.getElementById("salary").value;
        const department = document.getElementById("department").value;
        newPerson = new Employee(name, age, gender, jobTitle, salary, department);
    } else if (type === "student") {
        const university = document.getElementById("university").value;
        const major = document.getElementById("major").value;
        const faculty = document.getElementById("faculty").value;
        newPerson = new Student(name, age, gender, university, major, faculty);
    }

    people.push(newPerson);
    displaypeople();
}

// Display saved people on the page
function displaypeople() {
    const output = document.getElementById("output");
    output.innerHTML = "";  // Clear previous output

    people.forEach((person, index) => {
        const personInfo = document.createElement("div");
        personInfo.innerHTML = `
            <h3>Person ${index + 1}:</h3>
            <p>${person.introduce()}</p>
            ${person instanceof Employee ? `<p>${person.work()}</p>` : ""}
            ${person instanceof Student ? `<p>${person.study()}</p>` : ""}
        `;
        output.appendChild(personInfo);
    });
}

function calculateNamePercentage() {
    const nameCounts = new Map();

    people.forEach(person => {
        if (nameCounts.has(person.name)) {
            nameCounts.set(person.name, nameCounts.get(person.name) + 1);
        } else {
            nameCounts.set(person.name, 1);
        }
    });

    nameCounts.forEach((count, name) => {
        const percentage = (count / people.length) * 100;
        console.log(`Името ${name} се среща в ${percentage.toFixed(2)}% от случаите.`);
    });
}
