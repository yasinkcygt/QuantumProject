const readline = require('node:readline/promises');
const { stdin: input, stdout: output } = require('node:process');

const DataPacket = require('./DataPacket');
const DarkMatter = require('./DarkMatter');
const AntiMatter = require('./AntiMatter');
const QuantumCollapseException = require('./QuantumCollapseException');

async function Main() {
    const rl = readline.createInterface({ input, output });
    const storageList = []; 

    while (true) {
        console.log("\n============================================");
        console.log("      QUANTUM STORAGE CONTROL PANEL (JS)");
        console.log("============================================");
        console.log("1. Add New Object (Random Generation)");
        console.log("2. List Inventory (Status Report)");
        console.log("3. Analyze Object (Decreases Stability)");
        console.log("4. Emergency Cooling (Critical Objects Only)");
        console.log("5. Shutdown System");

        let choiceInput = await rl.question("\nOperation Selection: ");
        let choice = parseInt(choiceInput);

        if (choice === 5) {
            console.log("Shutting down system...");
            rl.close();
            process.exit(0);
        }
        
        switch (choice) {
            case 1:
                await addNewObject(storageList, rl);
                break;
            case 2:
                showInventory(storageList);
                break;
            case 3:
                await analyzeObject(storageList, rl);
                break;
            case 4:
                await performCooling(storageList, rl);
                break;
            default:
                console.log("Error: Please enter a valid numeric command.");
        }
    }
}

async function addNewObject(list, rl) {
    let typeIndex = Math.floor(Math.random() * 3);
    let id = await rl.question("Enter Object ID: ");
    if (!id.trim()) { console.log("ID cannot be empty."); return; }

    let st = parseInt(await rl.question("Enter Initial Stability (1-99): ")) || 0;
    let dl = parseInt(await rl.question("Enter Danger Level (1-10): ")) || 0;

    let newObj = null;
    switch (typeIndex) {
        case 0: newObj = new DataPacket(id, st, dl); break;
        case 1: newObj = new DarkMatter(id, st, dl); break;
        case 2: newObj = new AntiMatter(id, st, dl); break;
    }
    
    if (newObj && newObj.Stability > 0 && newObj.DangerLevel >= 1) {
        list.push(newObj);
        console.log(`Success: ${newObj.constructor.name} added to storage.`);
    } else {
        console.log("Failure: Invalid parameters detected. Object rejected.");
    }
}

function showInventory(list) {
    if (list.length === 0) console.log("\nStorage empty.");
    else list.forEach(o => console.log(o.getStatusInfo()));
}

async function analyzeObject(list, rl) {
    let searchID = await rl.question("Enter ID to Analyze: ");
    let obj = list.find(o => o.ObjectID === searchID);

    if (obj) {
        try {
            console.log(`Pre-Analysis Stability: ${obj.Stability}%`);
            obj.analyze();
            console.log(`Post-Analysis Stability: ${obj.Stability}%`);
        } catch (ex) {
            if (ex instanceof QuantumCollapseException) {
                console.log("\n!!! CRITICAL SYSTEM COLLAPSE !!!");
                console.log(ex.message);
                process.exit(0);
            } else {
                console.log("Error: " + ex.message);
            }
        }
    } else console.log("Object ID not found.");
}

async function performCooling(list, rl) {
    let searchID = await rl.question("Enter ID for Cooling: ");
    let obj = list.find(o => o.ObjectID === searchID);

    if (!obj) {
        console.log("Object ID not found.");
    } else if (typeof obj.emergencyCooling === 'function') {
        obj.emergencyCooling();
    } else {
        console.log("Denied: This object type is thermally stable and cannot be cooled.");
    }
}

Main();