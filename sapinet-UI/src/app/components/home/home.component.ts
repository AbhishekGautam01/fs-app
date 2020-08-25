import { Component, OnInit, ViewChild } from '@angular/core';
import { MedicineService } from 'src/app/services/medicine.service';
import { Medicine } from '../../core/constant/modles/medicine'
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  medicies: Array<Medicine>;
  displayColumn: string[]  = [];
  medicineList: MatTableDataSource<any>;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private medSer: MedicineService) { }

  ngOnInit(): void {
    this.medSer.GetAllMedicines().subscribe(data => {
      this.medicies = data;
      this.displayColumn = ['MedicineName', 'Brand', 'Quantity', 'Price', 'ExpiryTime', 'Notes'];
      this.medicineList = new MatTableDataSource(this.medicies);
      this.medicineList.sort = this.sort;
      this.medicineList.paginator = this.paginator;
    },     err => {
      console.log(err);
    });

  }

}
