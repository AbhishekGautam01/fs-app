import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { appEndpoint } from '../core/constant/app-endpoints';
import { Medicine } from '../core/constant/modles/medicine';

@Injectable({
  providedIn: 'root'
})
export class MedicineService {

  constructor(private httpClient: HttpClient) { }

  GetAllMedicines(): Observable<any> {
    const header: HttpHeaders = new HttpHeaders().set('Content-Type',  'application/json');
    return this.httpClient.get(environment.apiBaseUrl + appEndpoint.getAllMedicne, {headers: header});
  }

  CreateMedicine(medicine: Medicine): Observable<any>{
    const header: HttpHeaders = new HttpHeaders().set('Content-Type',  'application/json');
    return this.httpClient.post(environment.apiBaseUrl + appEndpoint.createMedicine, JSON.stringify(medicine), {headers: header});
  }
}
