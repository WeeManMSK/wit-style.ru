import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
    selector: 'app-footer',
    styleUrls: ['footer.component.scss'],
    templateUrl: 'footer.component.pug',
    host: {
        'class': 'footer',
    },
    encapsulation: ViewEncapsulation.None,
    preserveWhitespaces: false
})

export class FooterComponent implements OnInit {
    constructor() { }

    ngOnInit() { }
}