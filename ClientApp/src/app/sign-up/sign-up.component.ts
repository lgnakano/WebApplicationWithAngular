import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  myForm: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    const phone = this.fb.group({
      area: [],
      prefix: [],
      line: []
    });

    this.myForm = this.fb.group({
      email: ['', [
        Validators.required,
        Validators.email
      ]],
      password: ['', [
        Validators.required,
        Validators.pattern('^(?=.*[a-zA-Z])([a-zA-Z0-9]+)$')
      ]],
      age: [null, [
        Validators.required,
        Validators.minLength(2),
        Validators.min(18),
        Validators.max(65)
      ]],
      fName: [null, [
        Validators.required,
        Validators.minLength(2)
      ]],
      lName: [null, [
        Validators.required,
        Validators.minLength(2)
      ]],
      agree: [false, [
        Validators.requiredTrue
      ]]
    });
  }

  get email() {
    return this.myForm.get('email');
  }

  get fName() {
    return this.myForm.get('fName');
  }

  get lName() {
    return this.myForm.get('lName');
  }

  get password() {
    return this.myForm.get('password');
  }

  get age() {
    return this.myForm.get('age');
  }

  get agree() {
    return this.myForm.get('agree');
  }

}






