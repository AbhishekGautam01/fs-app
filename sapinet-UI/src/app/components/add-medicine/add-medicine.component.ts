import { Component, OnInit } from '@angular/core';
import { MedicineService } from 'src/app/services/medicine.service';
import { FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { Medicine } from 'src/app/core/constant/modles/medicine';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-medicine',
  templateUrl: './add-medicine.component.html',
  styleUrls: ['./add-medicine.component.scss']
})
export class AddMedicineComponent implements OnInit {

  addMedicine: FormGroup;
  submitButtonVisibility = true;
  newMedicine: Medicine;

  constructor(private medService: MedicineService, private router: Router) { }

  ngOnInit(): void {
    this.addMedicine = new FormGroup({
      medname: new FormControl(null, [Validators.required, Validators.pattern('[a-zA-Z ]*')]),
      brand: new FormControl(null, [Validators.required, Validators.pattern('[a-zA-Z ]*')]),
      quantity: new FormControl(null, [Validators.required]),
      expirytime: new FormControl(null, [Validators.required]),
      notes: new FormControl(null, [Validators.required]),
      price: new FormControl(null, [Validators.required])
    });
  }

  CreateMedcine(newMedicine: NgForm): void {
    this.newMedicine = newMedicine.value;
    this.medService.CreateMedicine(this.newMedicine).subscribe(res => {
      alert(res.message);
      this.router.navigateByUrl('/home');
    }, err => {
      this.addMedicine.reset();
      alert('Opps...' + err.error.message);
    });
  }

}
