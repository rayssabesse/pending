import React, { Component } from 'react';
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    View,
    Image,
} from 'react-native';

export default class Home extends Component {

    render() {

        return (
            <View style={styles.main}>

                <View style={styles.main_header}>
                    <View style={styles.vector}>
                        <Image
                            style={{ height: 110, width: 137, }}
                            source={require('../assets/up-right.png')} />
                    </View>

                    <View style={styles.header}>
                        <Text style={styles.header_text}>Bem-Vindo(a)!</Text>
                    </View>
                </View>

                <View style={styles.month_container}>
                    <View style={styles.month_box}>
                        <Text style={styles.month_box_text}>Lucro Mensal</Text>
                        <Text style={styles.month_box_text2}>R$ XXXX,XX</Text>
                    </View>

                    <View style={styles.month_box}>
                        <Text style={styles.month_box_text}>Lucro Estimado</Text>
                        <Text style={styles.month_box_text2}>R$ XXXX,XX</Text>
                    </View>
                </View>

                <View style={styles.total_budget}>
                    <View style={styles.total_budget_text}>
                        <Text style={styles.text_total}>Total</Text>
                        <Text style={styles.text_total2}>R$ XXXX,XX</Text>
                    </View>

                    <TouchableOpacity
                        style={styles.btnStats}>
                        <Image source={require('../assets/Right.png')} />
                    </TouchableOpacity>
                </View>

                <View style={styles.navBar}>
                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Main')}>
                        <Image source={require('../assets/Home.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Settings')}>
                        <Image source={require('../assets/Settings.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('statistics')}>
                        <Image source={require('../assets/Chart.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Clients')}>
                        <Image source={require('../assets/Client.png')} />
                    </TouchableOpacity>
                </View>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#F4F4F4',
    },

    navBar: {
        width: 360,
        height: 60,
        backgroundColor: '#222222',
        borderRadius: 20,
        marginBottom: 30,
        flexDirection: 'row',
        alignSelf: 'center',
        alignItems: 'center',
        justifyContent: 'space-around',
        position: 'absolute',
        bottom: 0,
    },

    btnStats: {
        height: 72,
        width: 60,
        backgroundColor: '#222222',
        borderRadius: 15,
        alignItems: 'center',
        justifyContent: 'center',
    },

    btnStats_image: {
        height: 'auto',
        width: 'auto',
    },

    total_budget: {
        height: 'auto',
        width: '100%',
        alignItems: 'center',
        justifyContent: 'space-around',
        flexDirection: 'row',
        marginTop: 30,
    },

    total_budget_text: {
        height: 'auto',
        width: 'auto',
        alignItems: 'flex-start',
    },

    text_total: {
        fontSize: 20,
        fontWeight: '600',
        color: 'rgba(34, 34, 34, 0.6)',
    },

    text_total2: {
        fontSize: 35,
        fontWeight: 'bold',
        color: '#222222',
    },

    month_container: {
        height: 'auto',
        width: '100%',
        alignSelf: 'center',
        justifyContent: 'space-around',
        flexDirection: 'row',
        marginTop: 40,
    },

    month_box: {
        height: 110,
        width: 175,
        borderRadius: 30,
        backgroundColor: '#fdfdfd',
        shadowColor: '#b7b7b7',
        shadowOpacity: 0.5,
        shadowRadius: 10,
        elevation: 3,
        justifyContent: 'center',
        alignItems: 'flex-start',
        paddingLeft: 23,
    },

    month_box_text: {
        color: 'rgba(34, 34, 34, 0.6)',
        fontWeight: '600',
        fontSize: 14,
    },

    month_box_text2: {
        color: '#222222',
        fontWeight: '700',
        fontSize: 15,
    },

    main_header: {
        height: 'auto',
        width: 'auto',
    },

    vector: {
        position: 'absolute',
        alignSelf: 'flex-end',
    },

    header: {
        height: 'auto',
        width: 'auto',
        marginTop: 50,
        marginLeft: 21,
    },

    header_text: {
        fontSize: 40,
        fontWeight: 'bold',
    },
});
