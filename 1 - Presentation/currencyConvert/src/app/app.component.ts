import { Component } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClientModule , HttpResponse, HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  title = 'Currency Convert';
  currencies: any[];
  erro: string[];
  numberTo: string;
  numberFrom: string;
  currencyFrom: string;
  currencyTo: string;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.carregarCurrency();
  }

  exibirAlertErro(alert) {
    if (alert) {
      this.erro = alert;
      setTimeout(() => { this.erro = []; }, 3000);
    }
  }

  carregarCurrency() {
    this.http.get(environment.url.baseApi.concat(environment.url.currencyType.padrao))
      .subscribe((res: HttpResponse<any>) => {
        this.currencies = JSON.parse(res.body);
      },
        (err) => {
          this.exibirAlertErro([err]);
        });
  }

  convertValue() {
    return this.http.get<any>(environment.url.baseApi.concat(environment.url.currencyValue.getValueConverted)
      .concat(this.currencyFrom)
      .concat(this.currencyTo)
      .concat(this.numberTo))
      .subscribe((res: HttpResponse<any>) => {
        this.numberFrom = JSON.parse(res.body);
      },
        (err) => {
          this.exibirAlertErro([err]);
        });
  }

  getSelectedFrom(event: Event) {
    this.currencyFrom = event.target['options'][event.target['options'].selectedIndex].text;
    this.numberTo !== '' ? this.convertValue() : null;
  }

  getSelectedTo(event: Event) {
    this.currencyTo = event.target['options'][event.target['options'].selectedIndex].text;
    this.numberTo !== '' ? this.convertValue() : null;
  }
}
