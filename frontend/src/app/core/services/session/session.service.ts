import { Injectable } from '@angular/core'

@Injectable({
    providedIn: 'root'
})
export class SessionService {
    active = true

    signIn(): void {
        this.active = true
    }

    signOut(): void {
        this.active = false
    }
}
