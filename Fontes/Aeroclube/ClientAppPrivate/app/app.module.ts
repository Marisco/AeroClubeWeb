import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { AeroclubeComponent } from './components/aeroclube/aeroclube.component';

@NgModule({
    bootstrap: [AppComponent ],
    declarations: [
        AppComponent,        
        //AeroclubeComponent
        
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
//            { path: '', redirectTo: 'AeroclubeController', pathMatch: 'full' },
          //  { path: 'aeroclube', component: AeroclubeComponent },            
          //  { path: '**', redirectTo: 'aeroclube' } 
        ])
    ]
})
export class AppModule {
}
