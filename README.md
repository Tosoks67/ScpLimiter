# ScpLimiter
is a simple and lightweight plugin which (as the name suggests) **limits the number of SCPs** that can spawn *per each round*

## Configuration
```yaml
scp_limit: 2
substitute_role: ClassD

```

`scp_limit` - SCP limit. Any SCP beyond that limit gets their role changed to `substitute_role`

`substitute_role` - the role to set to SCPs who surpassed the limit (see below for possible values)

### Possible values of `substitute_role`
 - `Spectator`
 - `Overwatch`
 - `Filmmaker`
 - `ClassD`
 - `Scientist`
 - `FacilityGuard`
 - `NtfPrivate`
 - `NtfSpecialist`
 - `NtfSergeant`
 - `NtfCaptain`
 - `ChaosRifleman`
 - `ChaosConscript`
 - `ChaosMarauder`
 - `ChaosRepressor`
 - `Tutorial`
 - `Scp173`
 - `Scp106`
 - `Scp049`
 - `Scp079`
 - `Scp096`
 - `Scp0492` (SCP-049-2)
 - `Scp939`
 - `Scp3114`
 - `Flamingo` (Only during Christmas events)
 - `AlphaFlamingo` (Only during Christmas events)
 - `ZombieFlamingo` (Only during Christmas events)
 - `NtfFlamingo` (Only during Christmas events)
 - `ChaosFlamingo` (Only during Christmas events)
