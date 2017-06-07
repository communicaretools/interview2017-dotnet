# Intervju-17: Oppgave
**Oppgave:** Registrering av studiedeltagere

**Kontekst:** Alle studier krever registrering av deltagere i de enkelte verktøyene. Denne funksjonaliteten blir derfor gjentatt på tvers av prosjektene. Oppgaven dreier seg om et felles system for å registrere personopplysninger om studiedeltagere, slik at vi ikke trenger å lage dette flere ganger.

**Teknologistack:**
* Front-end: Velg fritt mellom vuejs og angularjs, begge med bootstrap
* Backend: Velg fritt mellom nodejs og .net web api

**Oppstart:**
* For å kjøre programmet, start det fra Visual Studio
* Systemet lagrer data i katalogen `PasReg\Data` (ignorert av git), kopier data fra `ExampleData` for å ha noe å jobbe med

**User story:** Som en administrator ønsker jeg å kunne registrere en studiedeltager i en fritt valgt studie med opplysninger om fødselsnummer, kodeliste-id, navn, telefonnummer, epost, studie og gruppe innen studien. Studiene er predefinerte, og hvilke grupper man kan velge blant varierer fra studie til studie. Kodeliste-id er en kode som identifiserer pasienten innad i en studie.

**Implementer** i denne rekkefølgen:
* Skjemaet uten studiegruppe, uten validering og uten innsending
* Støtte for å velge gruppe ut fra valgt studie
* Innsending av data
* Klientsidevalidering, se listen "valideringsregler"
* Server-sidevalidering, samme som på klientsiden
* Klientsidestøtte for å vise resultatet av server-sidevalideringen
* Valideringsreglene i listen "ekstra valideringsregler"

**Valideringsregler:**
* Fødselsnummer: Påkrevd, 11 tegn
* Kodeliste-id: Påkrevd, 4 tegn
* Navn: Påkrevd
* Telefonnummer: Ikke påkrevd; hvis tilstede: 8 siffer
* Epost: Ikke påkrevd; hvis tilstede: gyldig epost-adresse
* Studie: Påkrevd
* Gruppe: Påkrevd

**Ekstra valideringsregler:**
* Fødselsnummer: 6 første skal være en gyldig dato på formatet ddmmåå (dag-måned-år, tosifret)
* Kodeliste-id: Første tegn bokstav A-Z, de tre resterende tegnende siffer 0-9
* Navn: Minimum to ord
* Studie: Påkrevd, én av studiene definert på serveren
* Gruppe: Påkrevd, én av gruppene definert for den valgte studien

**NB:** Oppgaven beskriver et hypotetisk scenario - å faktisk sette dette i drift ville være i strid med gjeldende bestemmelser om sikkerhet og personvern. Videre ville en reell implementasjon ha brukt en database; dette eksempelet bruker filsystemet for at det skal være enklere å forstå.
