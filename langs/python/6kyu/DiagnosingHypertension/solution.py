def calc_measured(measureds):
    systolic, diastolic = [], []
    
    for measured in measureds:
        s, d = measured.split('/')
        s = int(s)
        d = int(d)
        # any measured with systolic >= 180 and diastolic >= 110
        if s >= 180 and d >= 110:
            return True
        systolic.append(s)
        diastolic.append(d)

    if len(systolic) > 1 and sum(systolic) / len(systolic) >= 140.0:
        return True
    if len(systolic) > 1 and sum(diastolic) / len(diastolic) >= 90:
        return True
    return False

def hypertensive(patients):
    c = 0
    for patient in patients:
        if calc_measured(patient):
            c += 1

    return c

l = [["130/90","140/94"],
    ["160/110"],
    ["200/120"],
    ["150/94","140/90","120/90"],
    ["140/94","140/90","120/80","130/84"]]

print(hypertensive(l))       
"""
[
    "130/90" 130 is systolic | 90 is diastolic
    ["130/90","140/94"],
    ["160/110"],
    ["200/120"],
    ["150/94","140/90","120/90"],
    ["140/94","140/90","120/80","130/84"]
]
Average of all measured systolic pressures >= 140 mmHg. Must have minumum of 2 measurements.
Average of all measured diastolic presures >= 90 mmHg. Must have minimum of 2 measurements.
Any one measurement with systolic pressure >= 180 mmHg AND diastolic pressure >= 110 mmHg
"""