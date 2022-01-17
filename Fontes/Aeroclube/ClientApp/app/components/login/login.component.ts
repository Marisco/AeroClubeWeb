﻿
import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
    selector: 'login-component',
    templateUrl: './login.component.html'    
})
export class LoginComponent {
    constructor(private router: Router) {

    }    

    ValidarUsuario() {
        
        this.router.navigate(["aeroclube"]);
    }
}
