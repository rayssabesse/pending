import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import {
    StyleSheet,
    Text,
    TouchableOpacity,
    View,
    Image,
    ImageBackground,
    TextInput,
    SafeAreaView,
    PixelRatio,
} from 'react-native';
import { Searchbar, Switch } from 'react-native-paper';
import React, {
    Component,
    useState,
} from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { NavigationContainer } from '@react-navigation/native';

export default class Settings extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            toggle: false,
        };
    }



    render() {



        const languagesPortuguese = [
            'Inglês (EUA)',
            'Português (Brasil)',
            'Espanhol (Espanha)',
        ];
        const languagesEnglish = [
            'English (USA)',
            'Portuguese (Brazil)',
            'Spanish (Spain)',
        ];
        const languagesSpanish = [
            'Inglés (EE.UU.)',
            'Portugués (Brasil)',
            'Español (España)',
        ];


        return (


            <View style={styles.main}>
                <View style={styles.vector}>
                    <Image source={require('../assets/vector-original.png')} />
                </View>
                
                <View style={styles.mainHeader}>
                    <View style={styles.container_header}>
                        <View style={styles.containerAR}>
                            <Text style={styles.textName}>Nome completo</Text>
                        </View>

                        <View style={styles.containerData}>
                            <Text style={styles.textEmail}>usermail@pending.com</Text>
                            <Text style={styles.textPhone}>+55 11 90000-0000</Text>
                        </View>
                    </View>
                </View>

                <View style={styles.containerBusiness}>
                    <View>
                        <Text style={styles.textBusiness}>Meu Negócio</Text>
                    </View>

                    <View style={styles.containerCards}>
                        <View style={styles.cardClient}>
                            <View style={styles.mainInfoCard}>
                                <Text style={styles.textAddress}>Avenida Paulista, 1001 - Bela Vista, São Paulo - SP, 01311-100</Text>
                            </View>
                        </View>

                        <View style={styles.cardClient}>
                            <View style={styles.mainInfoCard}>
                                <Text style={styles.textAddress}>Nome do Estabelecimento</Text>
                            </View>
                        </View>
                    </View>

                    <View style={styles.containerCards}>
                        <View style={styles.cardClient}>
                            <View style={styles.mainInfoCard}>
                                <Text style={styles.textLine2}>idioma</Text>
                            </View>
                        </View>

                        <View style={styles.cardClient}>
                            <View style={styles.mainInfoCard}>
                                <Text style={styles.textLine2}>modo escuro</Text>
                                <Switch
                                    trackColor={{ false: 'light', true: '#222222' }}
                                    thumbColor="white"
                                    onValueChange={(value) => this.setState({ toggle: value })}
                                    value={this.state.toggle} />
                            </View>
                        </View>
                    </View>
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
                        onPress={() => this.props.navigation.navigate('')}>
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

    textLine2: {
        color: '#222222',
        fontSize: 14,
        fontWeight: '600',
        textTransform: 'uppercase',
    },

    containerCards: {
        flexDirection: 'row',
        height: 'auto',
        width: 'auto',
        justifyContent: 'space-between',
    },

    textAddress: {
        color: '#222222',
        fontSize: 14,
        fontWeight: '600',
    },

    cardClient: {
        width: 170,
        height: 100,
        backgroundColor: "#FDFDFD",
        borderRadius: 30,
        marginBottom: 15,
        marginTop: 15,
        paddingLeft: 15,
        paddingRight: 15,
        shadowColor: '#B7B7B7',
        shadowOpacity: 0.5,
        shadowRadius: 10,
        elevation: 3,
    },

    mainInfoCard: {
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
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

    textName: {
        fontSize: 23,
        fontWeight: '700',
        color: '#000',
        textTransform: 'uppercase',
    },

    mainHeader: {
        justifyContent: 'center',
        alignItems: 'center'
    },

    container_header: {
        width: '100%',
        height: 'auto',
        justifyContent: 'space-between',
    },

    containerAR: {
        marginLeft: 25,
        marginTop: 42,
    },

    vector: {
        position: 'absolute',
        height: 'auto',
        width: 'auto',
        flexDirection: 'column',
        marginTop: 30,
        justifyContent: 'center',
        alignItems: 'center',
        height: '100%',
    },

    textEmail: {
        fontSize: 13,
        color: 'rgba(34, 34, 34, 0.6)',
    },

    textPhone: {
        fontSize: 13,
        color: 'rgba(34, 34, 34, 0.6)',
    },

    containerData: {
        marginLeft: 25,
        marginTop: 2,
    },

    containerBusiness: {
        marginLeft: 25,
        marginRight: 25,
        marginTop: 30,
    },

    textBusiness: {
        fontSize: 23,
        color: 'rgba(34, 34, 34, 0.6)',
        fontWeight: '600',
    },


});
