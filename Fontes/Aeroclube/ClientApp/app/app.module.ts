import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { LoginComponent } from './components/login/login.component';
import { AeroclubeComponent } from './components/aeroclube/aeroclube.component'


@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,        
        LoginComponent,
        AeroclubeComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: 'login', component: LoginComponent },                
            { path: '**', redirectTo: 'login' },          
            { path: 'AeroclubeComponent', component: AeroclubeComponent },
        ])
    ]
})
export class AppModule {
}
